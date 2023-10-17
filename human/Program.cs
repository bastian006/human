class humano{
    public string Nombre{get; private set;}
    public int Fuerza{get; private set;}
    public int Inteligencia{get; private set;}
    public int Destreza{get; private set;}
    public int Salud{get; private set;}

    public humano(string name)
    {
        Nombre = name;
        Fuerza = 3;
        Inteligencia = 3;
        Destreza = 3;
        Salud = 100;
    }

    public humano(string nombre, int fuerza, int inteligencia, int destreza, int salud){
        Nombre = nombre;
        Fuerza = fuerza;
        Inteligencia = inteligencia;
        Destreza = destreza;
        Salud = salud;
    }

    public int Attack(humano target){
        int daño = Fuerza * 3;
        target.Salud -= daño;

        if(target.Salud<0){
            target.Salud = 0;
        }
        return target.Salud;
    }

}
