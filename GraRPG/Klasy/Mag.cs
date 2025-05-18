public class Mag : Hero{

    public int Moc;

    public Mag(string nazwa, int hp, int atak, int moc): base(nazwa, hp, atak)
    {
        Moc = moc;
    }

    public void OdejmijHp(int atak) {
        Hp -= atak;
    }

    public int PobierzSileAtaku(){
        return Atak + (Moc / 5);
    }

}