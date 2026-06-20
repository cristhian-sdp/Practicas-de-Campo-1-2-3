using System;
using System.Windows.Forms;

namespace PC3_Ejercicio_1
{
    public partial class Form1 : Form
    {
        // Pila para el historial de estados (botón Deshacer)
        private readonly Pila<string> _historial = new Pila<string>();

        public Form1()
        {
            InitializeComponent();
            txtFormula.TextChanged += TxtFormula_TextChanged;
        }

        //  EVENTO TextChanged apila el estado anterior
        private string _textoAnterior = "";

        private void TxtFormula_TextChanged(object sender, EventArgs e)
        {
            // Apilamos el estado que existía ANTES del cambio
            _historial.Apilar(_textoAnterior);
            _textoAnterior = txtFormula.Text;
        }

        //  BOTÓN VALIDAR  –  Verifica paréntesis balanceados
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string formula = txtFormula.Text.Trim();

            if (string.IsNullOrEmpty(formula))
            {
                MostrarMensaje("Escribe una fórmula antes de validar.", false);
                return;
            }

            Pila<char> pilaParentesis = new Pila<char>();

            foreach (char c in formula)
            {
                // Si es apertura, apilamos
                if (c == '(' || c == '[' || c == '{')
                {
                    pilaParentesis.Apilar(c);
                }
                // Si es cierre, verificamos correspondencia
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pilaParentesis.EstaVacia)
                    {
                        MostrarMensaje($"❌ Error: '{c}' sin apertura correspondiente.", false);
                        return;
                    }

                    char tope = pilaParentesis.Desapilar();

                    bool esCorrecta = (c == ')' && tope == '(') ||
                                      (c == ']' && tope == '[') ||
                                      (c == '}' && tope == '{');

                    if (!esCorrecta)
                    {
                        MostrarMensaje($"❌ Error: '{c}' no cierra '{tope}' correctamente.", false);
                        return;
                    }
                }
            }

            if (pilaParentesis.EstaVacia)
                MostrarMensaje("✅ Fórmula válida: paréntesis correctamente balanceados.", true);
            else
                MostrarMensaje($"❌ Error: quedan {pilaParentesis.Tamaño} paréntesis sin cerrar.", false);
        }

        //  BOTÓN EVALUAR  –  Notación postfija (Polish Inversa)
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string formula = txtFormula.Text.Trim();

            if (string.IsNullOrEmpty(formula))
            {
                MostrarMensaje("Escribe una fórmula antes de evaluar.", false);
                return;
            }

            try
            {
                double resultado = EvaluarExpresion(formula);
                MostrarMensaje($"🧮 Resultado: {resultado:G}", true);
            }
            catch (Exception ex)
            {
                MostrarMensaje($"❌ Error al evaluar: {ex.Message}", false);
            }
        }

        /// Convierte de infija a postfija (Shunting-Yard) y luego evalúa la expresión postfija.
        private double EvaluarExpresion(string expresion)
        {
            // Fase 1: tokenizar
            var tokens = Tokenizar(expresion);

            // Fase 2: Shunting-Yard
            Pila<string> pilaOp = new Pila<string>();   // operadores
            var colaSalida = new System.Collections.Generic.Queue<string>();

            foreach (string token in tokens)
            {
                if (double.TryParse(token, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out _))
                {
                    // Número va directo a la salida
                    colaSalida.Enqueue(token);
                }
                else if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    // Mientras haya operador en el tope con mayor o igual precedencia
                    while (!pilaOp.EstaVacia &&
                           pilaOp.VerTope() != "(" &&
                           Precedencia(pilaOp.VerTope()) >= Precedencia(token))
                    {
                        colaSalida.Enqueue(pilaOp.Desapilar());
                    }
                    pilaOp.Apilar(token);
                }
                else if (token == "(")
                {
                    pilaOp.Apilar(token);
                }
                else if (token == ")")
                {
                    // Vaciar hasta encontrar '('
                    while (!pilaOp.EstaVacia && pilaOp.VerTope() != "(")
                        colaSalida.Enqueue(pilaOp.Desapilar());

                    if (pilaOp.EstaVacia)
                        throw new Exception("Paréntesis desbalanceados.");

                    pilaOp.Desapilar(); // quitar '('
                }
                else
                {
                    throw new Exception($"Token desconocido: '{token}'");
                }
            }

            while (!pilaOp.EstaVacia)
            {
                string op = pilaOp.Desapilar();
                if (op == "(" || op == ")")
                    throw new Exception("Paréntesis desbalanceados.");
                colaSalida.Enqueue(op);
            }

            // Fase 3: Evaluar postfija
            Pila<double> pilaValores = new Pila<double>();

            foreach (string token in colaSalida)
            {
                if (double.TryParse(token, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    pilaValores.Apilar(num);
                }
                else
                {
                    if (pilaValores.Tamaño < 2)
                        throw new Exception("Expresión mal formada.");

                    double b = pilaValores.Desapilar();
                    double a = pilaValores.Desapilar();

                    double res = token switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => b == 0
                              ? throw new DivideByZeroException("División por cero.")
                              : a / b,
                        _ => throw new Exception($"Operador no soportado: {token}")
                    };

                    pilaValores.Apilar(res);
                }
            }

            if (pilaValores.Tamaño != 1)
                throw new Exception("La expresión tiene operandos de más.");

            return pilaValores.Desapilar();
        }

        /// Separa la expresión en tokens (números y operadores).
        private System.Collections.Generic.List<string> Tokenizar(string expresion)
        {
            var tokens = new System.Collections.Generic.List<string>();
            int i = 0;

            while (i < expresion.Length)
            {
                char c = expresion[i];

                if (char.IsWhiteSpace(c)) { i++; continue; }

                if (char.IsDigit(c) || c == '.')
                {
                    // Leer número completo (incluyendo decimales)
                    string num = "";
                    while (i < expresion.Length &&
                           (char.IsDigit(expresion[i]) || expresion[i] == '.'))
                    {
                        num += expresion[i++];
                    }
                    tokens.Add(num);
                    continue;
                }

                if (c == '+' || c == '-' || c == '*' || c == '/' ||
                    c == '(' || c == ')')
                {
                    tokens.Add(c.ToString());
                    i++;
                    continue;
                }

                throw new Exception($"Carácter no válido: '{c}'");
            }

            return tokens;
        }

        /// Devuelve la precedencia de un operador.
        private int Precedencia(string op)
        {
            return op switch
            {
                "+" or "-" => 1,
                "*" or "/" => 2,
                _ => 0
            };
        }

        //  BOTÓN DESHACER  –  Recupera el estado anterior
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (_historial.EstaVacia)
            {
                MostrarMensaje("⚠️ No hay cambios para deshacer.", false);
                return;
            }

            // Desvinculamos el evento para no apilar el cambio del Deshacer
            txtFormula.TextChanged -= TxtFormula_TextChanged;

            string estadoAnterior = _historial.Desapilar();
            txtFormula.Text = estadoAnterior;
            _textoAnterior = estadoAnterior;

            // Restauramos el evento
            txtFormula.TextChanged += TxtFormula_TextChanged;

            MostrarMensaje($"↩️ Deshecho. Estados restantes en pila: {_historial.Tamaño}", true);
        }

        //  HELPER: Mostrar resultado en el label
        private void MostrarMensaje(string mensaje, bool exito)
        {
            lblResultado.Text = mensaje;
            lblResultado.ForeColor = exito
                ? System.Drawing.Color.DarkGreen
                : System.Drawing.Color.DarkRed;
        }
    }
}