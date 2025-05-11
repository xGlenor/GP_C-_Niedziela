
public class Silnik {

    private int moc;
    public bool czyWlaczony;

    public void ZmienMoc(int moc) {

        if (!czyWlaczony) {
            Console.WriteLine("Nie wolno zmienic mocy! Silnik jest wyłączony");
        }else {

            this.moc += moc;
            Console.WriteLine($"Aktualna moc silnika to: {this.moc}");           

        }


    }


}