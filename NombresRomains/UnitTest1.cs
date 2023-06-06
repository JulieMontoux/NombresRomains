namespace NombresRomains
{
    public class UnitTest1
    {
        [Theory(DisplayName ="si on envoie {nombreArabe} alors on obtient {nombreRomain}")]

        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        public void Test1(int nombreArabe, string nombreRomainAttendu)
        {
            var nombreRomainObtenu = Convertisseur.Convertir(nombreArabe);

            Assert.Equal(nombreRomainAttendu, nombreRomainObtenu);
        }
    }
}