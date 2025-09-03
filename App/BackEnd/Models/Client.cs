namespace BackEnd.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string BrojPasosa { get; set; }
        public string DatumRodjenja { get; set; }

        public string EmailAdresa { get; set; }
        public string BrojTelefona { get; set; }

        public Client(int id, string ime, string prezime, string brojPasosa, string datumRodjenja, string emailAdresa, string brojTelefona)
        {
            this.ID = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrojPasosa = brojPasosa;
            this.DatumRodjenja = datumRodjenja;
            this.EmailAdresa = emailAdresa;
            this.BrojTelefona = brojTelefona;
        }
    }
}
