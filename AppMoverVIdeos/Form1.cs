using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace AppMoverVIdeos
{
    public partial class Form1 : Form
    {

        private readonly string defaultDestName = "00_SOLO_VIDEOS";

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            // Modo (combo)            
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.Items.Clear();
            cmbMode.Items.AddRange(new object[] { "Simular (dry-run)", "Ejecutar (real)" });
            cmbMode.SelectedIndex = 0; // por defecto simular

            // Acción (combo)
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.Items.Clear();
            cmbAction.Items.AddRange(new object[] { "Mover", "Copiar" });
            cmbAction.SelectedIndex = 0; // por defecto mover

            // Destino por defecto
            if (string.IsNullOrWhiteSpace(txtDest.Text))
                txtDest.Text = defaultDestName;

            // Extensiones por defecto: todas marcadas
            chkAllExts.Checked = true;
            SetAllExts(true);

            lblStatus.Text = "Estado inicial";
        }



        private void btnBrowseRoot_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();
            dlg.Description = "Selecciona el directorio raíz a procesar"; // Abrimos el cuadro de diálogo par seleccionar la carpeta raíz
            dlg.ShowNewFolderButton = false;
            if (dlg.ShowDialog(this) == DialogResult.OK)
                txtRoot.Text = dlg.SelectedPath;

        }



        private void chkAllExts_CheckedChanged(object sender, EventArgs e)
        {
            SetAllExts(chkAllExts.Checked);
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Procesando...";
            btnRun.Enabled = false;

            try
            {
                // Validaciones y parámetros
                string root = txtRoot.Text.Trim();
                if (string.IsNullOrWhiteSpace(root) || !Directory.Exists(root))
                {
                    MessageBox.Show(this, "Selecciona una carpeta origen válida.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string destInput = txtDest.Text.Trim();
                string destRoot;

                if (string.IsNullOrWhiteSpace(destInput))
                {
                    destRoot = Path.Combine(root, defaultDestName);
                }
                else if (Path.IsPathRooted(destInput))
                {
                    destRoot = destInput;
                }
                else
                {
                    destRoot = Path.Combine(root, destInput);
                }

                bool dryRun = (cmbMode.SelectedIndex == 0);   // 0 = Simular
                bool doCopy = (cmbAction.SelectedIndex == 1); // 1 = Copiar

                var selectedExts = GetSelectedExtensions();
                if (selectedExts.Count == 0)
                {
                    MessageBox.Show(this, "Selecciona al menos una extensión.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Directorio de logs en Mis Documentos
                string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string logDir = Path.Combine(myDocs, "SoloVideos", "logs");
                Directory.CreateDirectory(logDir);
                string stamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
                string logPath = Path.Combine(logDir, $"video_extract_{(dryRun ? "dryrun_" : "")}{stamp}.log");

                // Evitar recursión si el destino está dentro del root
                string? avoidDir = null; //Con ? (nullable reference types habilitado) - el compilador sabe que la variable puede ser null (no avisa)
                try
                {
                    var rel = Path.GetRelativePath(root, destRoot); //me decuelve la ruta parcial de inicio a destino (normalmente será 00_SOLO_VIDEOS)
                    if (!rel.StartsWith(".."))
                    {
                        avoidDir = Path.GetFullPath(destRoot); //Este directorio lo omitiré de la búsqueda (es donde dejaré los videos)
                    }
                }
                catch { }

                int found = 0, done = 0;
                var sbFile = new StringBuilder();

                void Log(string line) => sbFile.AppendLine(line); // =>  equivalente a { return ...; } pero en una sola línea).

                Log($"# Origen: {root}");
                Log($"# Destino: {destRoot}");
                Log($"# Modo: {(dryRun ? "DRY-RUN" : "REAL")}  |  Acción: {(doCopy ? "COPIAR" : "MOVER")}");
                Log($"# Extensiones: {string.Join(", ", selectedExts.OrderBy(x => x))}");
                Log($"# Fecha/hora: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                Log("");

                await Task.Run(() =>
                {
                    foreach (string src in Directory.EnumerateFiles(root, "*.*", SearchOption.AllDirectories))
                    {
                        //Si el archivo pertenece al directorio final (se evita) lo salto
                        if (avoidDir != null &&
                            Path.GetFullPath(src).StartsWith(avoidDir, StringComparison.OrdinalIgnoreCase))
                            continue;
                        
                        //Aseguramos que es del tipo que queremos mover
                        string ext = Path.GetExtension(src).ToLowerInvariant();
                        if (!selectedExts.Contains(ext)) continue;


                        //Esta parte se ejecuta si es del tipo que hemos seleccionado
                        found++;

                        string relDir = Path.GetRelativePath(root, Path.GetDirectoryName(src)!);
                        string dstDir = Path.Combine(destRoot, relDir); //Directorio igual al que proviene... deberé crearlo
                        string dst = Path.Combine(dstDir, Path.GetFileName(src)); // nuevo nombre del archivo (ruta completa)

                        string action = doCopy ? "COPIAR" : "MOVER";
                        Log($"{action}: {src} -> {dst}");

                        if (dryRun) continue;
                        
                        //Aquí solo entrará cuando estemos en Real (no en un dry-run)
                        try
                        {
                            Directory.CreateDirectory(dstDir);
                            string finalDst = EnsureUnique(dst);

                            if (doCopy) File.Copy(src, finalDst, overwrite: false);
                            else File.Move(src, finalDst);

                            done++;
                        }
                        catch (Exception ex)
                        {
                            Log($"ERROR: {ex.Message}");
                        }
                    }
                });

                Log("");
                Log($"# Total vídeos detectados: {found}");
                Log($"# Total {(dryRun ? "operaciones simuladas" : "archivos procesados")}: {done}");
                Log("FIN DE LOG. CREADO POR Ricardo Serón Agosto 2025");
                File.WriteAllText(logPath, sbFile.ToString(), Encoding.UTF8);

                lblStatus.Text = $"OK · Detectados: {found} · {(dryRun ? "TODO SIMULADO" : $"Procesados: {done}")} \r\nLog: {logPath}";
            }
            finally
            {
                btnRun.Enabled = true;
            }
        }


        private void SetAllExts(bool check)
        {
            chkExtMp4.Checked = check;
            chkExtM4v.Checked = check;
            chkExtMov.Checked = check;
            chkExtAvi.Checked = check;
            chkExtMkv.Checked = check;
            chkExtWmv.Checked = check;
            chkExtFlv.Checked = check;
            chkExtWebm.Checked = check;
            chkExtM2ts.Checked = check;
            chkExt3gp.Checked = check;
        }
        private HashSet<string> GetSelectedExtensions()
        {
            var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            if (chkExtMp4.Checked) set.Add(".mp4");
            if (chkExtM4v.Checked) set.Add(".m4v");
            if (chkExtMov.Checked) set.Add(".mov");
            if (chkExtAvi.Checked) set.Add(".avi");
            if (chkExtMkv.Checked) set.Add(".mkv");
            if (chkExtWmv.Checked) set.Add(".wmv");
            if (chkExtFlv.Checked) set.Add(".flv");
            if (chkExtWebm.Checked) set.Add(".webm");
            if (chkExtM2ts.Checked) set.Add(".m2ts");
            if (chkExt3gp.Checked) set.Add(".3gp");
            return set;
        }

        private string EnsureUnique(string path)
        {
            if (!File.Exists(path)) return path;
            string dir = Path.GetDirectoryName(path)!;
            string name = Path.GetFileNameWithoutExtension(path);
            string ext = Path.GetExtension(path);
            int i = 1;
            string candidate;
            do
            {
                candidate = Path.Combine(dir, $"{name}_{i}{ext}");
                i++;
            } while (File.Exists(candidate));
            return candidate;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string logsDir = Path.Combine(docsPath, "SoloVideos", "Logs");

                if (!Directory.Exists(logsDir))
                {
                    MessageBox.Show("No se ha encontrado la carpeta de logs.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // obtener el último archivo de log
                var lastLog = new DirectoryInfo(logsDir)
                    .GetFiles("*.log", SearchOption.TopDirectoryOnly)
                    .OrderByDescending(f => f.LastWriteTime)
                    .FirstOrDefault();

                if (lastLog == null)
                {
                    MessageBox.Show("No se encontraron logs en la carpeta.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // abrir en bloc de notas
                Process.Start(new ProcessStartInfo()
                {
                    FileName = "notepad.exe",
                    Arguments = "\"" + lastLog.FullName + "\"",
                    UseShellExecute = false
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el log: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
