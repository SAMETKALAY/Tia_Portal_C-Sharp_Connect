using S7.Net;
namespace Siemens_Plc_Connect_Scada {
    public partial class Plc_Connect : Form
    {
        Plc plc1;
        public Plc_Connect()
        {
            InitializeComponent();
        }
        CpuType plc_Cpu;
        private void button_Connect_Click(object sender, EventArgs e)
        {

            plc1 = new Plc(plc_Cpu, textBox_Plc_Ip_1.Text + "." + textBox_Plc_Ip_2.Text + "." + textBox_Plc_Ip_3.Text + "." + textBox_Plc_Ip_4.Text, (short)System.Convert.ToInt32(comboBox_Plc_Rack.Text), (short)System.Convert.ToInt32(comboBox_Plc_Slot.Text));
         
              try
                {
                   plc1.Open();
                    button_Connect.BackColor = Color.Green;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plc Connect Error:" + ex.ToString());
                    button_Connect.BackColor = Color.Red;
                }


            }

           
        

        private void comboBox_Plc_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Plc_Type.Text == "S71500") { plc_Cpu = CpuType.S71500; }
            else if (comboBox_Plc_Type.Text == "S71200") { plc_Cpu = CpuType.S71200; }
            else if (comboBox_Plc_Type.Text == "S7200Smart") { plc_Cpu = CpuType.S7200Smart; }
            else if (comboBox_Plc_Type.Text == "S7200") { plc_Cpu = CpuType.S7200; }
            else if (comboBox_Plc_Type.Text == "S7300") { plc_Cpu = CpuType.S7300; }
            else if (comboBox_Plc_Type.Text == "S7400") { plc_Cpu = CpuType.S7400; }
            else { MessageBox.Show("Plc Type Selected Error. Please Try Selected Again"); }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
