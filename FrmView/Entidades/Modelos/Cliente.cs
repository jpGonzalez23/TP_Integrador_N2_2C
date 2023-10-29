namespace Entidades.Modelos
{
    public class Cliente
    {
        private int id;
        private int cantComensales;
        private string nombre;
        private string dni;

        public Cliente(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public int Id 
        {
            get { return this.id; }

            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
            }
        }

        public string Nombre 
        { 
            get { return this.nombre; } 
            set
            {
                if (this.ValidarStringVacio(value))
                {
                    this.nombre = value;
                }
            }
        }
        
        public string Dni 
        { 
            get { return this.dni; } 
            set
            {
                if (this.ValidarStringVacio(value))
                {
                    this.dni = value;
                }
            } 
        }

        public int CantComensales
        {
            get
            {
                return this.cantComensales;
            }
            set
            {
                if (value > 0)
                {
                    this.cantComensales = value;
                }
            }
        }

        private bool ValidarStringVacio(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? false : true;
        }
    }
}