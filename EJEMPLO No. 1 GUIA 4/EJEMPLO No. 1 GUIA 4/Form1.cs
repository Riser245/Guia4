namespace EJEMPLO_No._1_GUIA_4
{
    public partial class Calculadora : Form
    {

        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int Operacion;

        public Calculadora()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }

        private void btncorregir_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 0;
            }

           


        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 0;
            }


           

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 0;
            }


            

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                Operacion = 0;
            }

            

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operacion == 0)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                        

                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion para realizar");
                    }

                    

                }
            }

            catch
            {
                MessageBox.Show("Esta operacion requiere dos operandos");
            }



        }



        public double operar(double operador1, double operador2, String signo)
        {
            double Resultado = 0.0;
            switch (signo) 
            {
                case "+":
                    Resultado = operador1 + operador2;
                    break;

                case "-":
                    Resultado = operador1 - operador2;
                    break;

                case "*":
                    Resultado = operador1 * operador2;
                    break;

                case "/":
                    Resultado = operador1 / operador2;
                    break;

                    default:
                    break;
            }

            return Resultado;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        private void limpiar_pantalla()
        {
            Pantalla.Text = "";
        }

        public double obtener_valor()
        {
            double valor = Convert.ToDouble(Pantalla.Text);
            limpiar_pantalla();
            return valor;
        }

        public void actualizar_pantalla (String texto)
        {
            Pantalla.Text = Pantalla.Text + texto;
        }


        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}