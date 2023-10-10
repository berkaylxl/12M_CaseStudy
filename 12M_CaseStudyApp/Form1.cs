using DevExpress.Export;
using DevExpress.XtraPrinting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _12M_CaseStudyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=LAPTOP-BEKO;Initial Catalog=TEST;Integrated Security=True";
        string currentKod = "";
        int baslangic_Tarihi = 0;
        int bitis_Tarihi= 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde datepicker üzerinden tarih bilgisi alınır
            baslangic_Tarihi = Convert.ToInt32((datePicker_baslangicTarihi.Value.Date).ToOADate());
            bitis_Tarihi = Convert.ToInt32((datePicker_bitisTarihi.Value.Date).ToOADate());
        }

        private DataTable List_MalKod(string searchText)
        {
            DataTable table = new DataTable(); // Verileri saklamak için datatable oluşturulur.
            using (SqlConnection connection = new SqlConnection(connectionString)) //Veri tabanına bağlanmak için connection nesnesi oluşturulur.
            {
                connection.Open(); //veritabanı bağlantısı açılır.
                string query = "SELECT MalKodu, MalAdi FROM STK WHERE MalKodu LIKE @searchText OR MalAdi LIKE @searchText"; //ilgili veriyi getirecek sql sorgusu yazılır.
                SqlCommand command = new SqlCommand(query, connection);// sorgu ve bağlantı command a tanımlanır.
                command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");//parametre doldurulur.

                using (SqlDataReader reader = command.ExecuteReader()) // sorgu çalıştırılır. Reader ile sorgu sonucu okunarak table üzerine yüklenir.
                {
                    table.Load(reader);
                }
                connection.Close(); // bağlantı kapatılır.
            }
            return table;
        }
   
        private void FillGrid(string malKod)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable resultTable = new DataTable();
                SqlCommand command = new SqlCommand("usp_GetDataList", connection);
                command.CommandType = CommandType.StoredProcedure;//Sorgu türünün store procedure olduğu tanımlanır.
                command.Parameters.AddWithValue("@MalKodu", malKod);// parametre değerleri verilir.
                command.Parameters.AddWithValue("@Baslangic_Tarihi", baslangic_Tarihi);
                command.Parameters.AddWithValue("@Bitis_Tarihi", bitis_Tarihi);

                SqlDataAdapter adapter = new SqlDataAdapter(command);// Veriler adapter ile çekilir
                adapter.Fill(resultTable); // ve datatable üzerine doldurulur.
               
                gridControl1.DataSource=resultTable; // Gridcontrol üzerinde datalar listelenir.
                connection.Close();
            }
        }
        private void cmbx_malKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox itemleri temizlenir.
            currentKod = cmbx_malKodu.Text; //combobox texti alınır.
            FillGrid(currentKod); // grid güncellenir.
        }
        private void cmbx_malKodu_TextChanged(object sender, EventArgs e)
        {
            cmbx_malKodu.Properties.Items.Clear(); // combobox itemleri temizlenir.

            string searchText = cmbx_malKodu.Text;
            DataTable searchTable = List_MalKod(searchText);  //Girilen mal kodu/adi  na göre mal kodları getirilir. 

            // Table üzerindeki tüm satırlar döndürülür. Ve Malkodu sütunu comboboxa item olarak verilir.
            foreach (DataRow row in searchTable.Rows)  
            {
                string kod = row["MalKodu"].ToString();
                cmbx_malKodu.Properties.Items.Add(kod);
            }
            cmbx_malKodu.ShowPopup();// combobox items listesi açılır.
        }
        private void datePicker_baslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            //datepicker üzerinden tarih bilgisi int olarak alınır
           baslangic_Tarihi = Convert.ToInt32((datePicker_baslangicTarihi.Value.Date).ToOADate());
            if (currentKod != "") // Eğer malodu girilmişse grid doldurulur.
                FillGrid(currentKod);
        }
        private void datePicker_bitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            bitis_Tarihi = Convert.ToInt32((datePicker_bitisTarihi.Value.Date).ToOADate());
            if(currentKod != "")
                FillGrid(currentKod);
        }
        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            //Yazdırma önizlemesini görüntülenir.
            gridControl1.ShowPrintPreview();
        }
        private void btn_excel_Click(object sender, EventArgs e)
        {
            //Dosya kaydetme işlemi için bir dosya seçme penceresi açar.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";       //Kaydedilecek dosyanın türünü filtreler

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // kaydet butonu tıklanmışsa
            {
                XlsxExportOptionsEx options = new XlsxExportOptionsEx();
                options.ExportType = ExportType.WYSIWYG;// Option olarak dışarıya verilerin göründüğü gibi aktarılması gerektiği bildirilir..
                gridView1.ExportToXlsx(saveFileDialog.FileName, options);// Excel olarak aktarılır.
            }
        }
    }
}
