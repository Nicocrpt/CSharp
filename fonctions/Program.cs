using System.Linq.Expressions;

int addition(int a, int b) {
    return a + b;
}


void nbJour(int jj,int mm, int aa) {
    System.Console.Write("Votre j de naissance : ");
    int ju = int.Parse(Console.ReadLine());
    System.Console.Write("Votre m de naissance : ");
    int mu = int.Parse(Console.ReadLine());
    System.Console.Write("Votre a de naissance : ");
    int au = int.Parse(Console.ReadLine());
    

    int nbJ = 0 ;

    // addition Années

    for (int i = (au+1); i < aa ; i++) {
        if (((i%4 == 0) && (i%100) != 0) || (i%400 == 0)) {
            nbJ += 366;
        }else{
            nbJ += 365;
        }
    }
    System.Console.WriteLine(nbJ);

    // addition J

    if (mu == 1 || mu == 3 || mu == 5 || mu == 7 || mu == 8 || mu == 10 || mu == 12) {
        nbJ += (31-ju);
    }else if (mu == 2) {
        if (((aa%4 == 0) && (aa%100) != 0) || (aa%400 == 0)) {
            nbJ += (29-ju);
        } else {
            nbJ += (28-ju);
        }
    }else {
        nbJ += (30-ju);
    }
    nbJ += jj;

    System.Console.WriteLine(nbJ);
    
    if (mu < mm) {
        for (int i = 1; i <=12 ; i++) {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12) {
            nbJ += 31;
            }else if (i == 2) {
                if (((aa%4 == 0) && (aa%100) != 0) || (aa%400 == 0)) {
                    nbJ += 29;
                } else {
                    nbJ += 28;
                }
            }else {
                nbJ += 30;
            }
        }
    }

    System.Console.WriteLine(nbJ);
}



nbJour(22, 2, 2024);