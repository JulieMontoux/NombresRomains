namespace NombresRomains
{
    public class UnitTest1
    {
        [Theory(DisplayName ="si on envoie {nombreArabe} alors on obtient {nombreRomain}")]

        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        public void Test1(int nombreArabe, string nombreRomainAttendu)
        {
            var nombreRomainObtenu = Convertisseur.Convertir(nombreArabe);

            Assert.Equal(nombreRomainAttendu, nombreRomainObtenu);
        }
    }
}