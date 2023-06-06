namespace NombresRomains
{
    public class UnitTest1
    {
        [Theory(DisplayName ="si on envoie {nombreArabe} alors on obtient {nombreRomain}")]

        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(5000, "V")]
        [InlineData(11, "XI")]
        public void Test1(int nombreArabe, string nombreRomainAttendu)
        {
            var nombreRomainObtenu = Convertisseur.Convertir(nombreArabe);

            Assert.Equal(nombreRomainAttendu, nombreRomainObtenu);
        }

        [Theory(DisplayName = "on envoie 1, 2, 3")]

        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void TestUnites(int x)
        {
            var nombreRomainObtenu = Convertisseur.Convertir(x);

            Assert.Equal(new string('I', x), nombreRomainObtenu);
        }

        [Theory(DisplayName ="on envoie 4,5")]

        [InlineData(4)]
        [InlineData(5)]
        public void TestQuatre(int x)
        {
            var nombreRomainObtenu = Convertisseur.Convertir(x);
            var iAvant = new string('I', 5 - x);
            Assert.Equal(new string(iAvant + 'V'), nombreRomainObtenu);
        }

        [Theory(DisplayName ="on envoie 5,6,7,8")]

        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestPlusCinqUnites(int x)
        {
            var nombreRomainObtenu = Convertisseur.Convertir(x);
            var iTerminaux = new string('I', x-5);
            Assert.Equal(new string('V'+ iTerminaux), nombreRomainObtenu);
        }

        [Theory(DisplayName ="on envoie 9")]

        [InlineData(9)]
        [InlineData(10)]
        public void TestNeuf(int x)
        {
            var nombreRomainObtenu = Convertisseur.Convertir(x);
            var iAvant= new string('I', 10 - x);
            Assert.Equal(new string(iAvant + 'X'), nombreRomainObtenu);
        }
    }
}