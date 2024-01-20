// EX 1

    /* Console.Write("Introdu numărul de elemente din vector: ");
       int n = Convert.ToInt32(Console.ReadLine());
       int[] vector = new int[n];
       int suma = 0;

       for (int i = 0; i < n; i++)
       {
           Console.Write("Introdu elementul " + (i + 1) + ": ");
           vector[i] = Convert.ToInt32(Console.ReadLine());
           suma += vector[i];
       }

       Console.WriteLine("Suma elementelor vectorului este: " + suma);*/

// EX 2

/*Console.Write("Introdu numărul de elemente din vector: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Introdu elementul " + (i + 1) + ": ");
    vector[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Introdu valoarea k: ");
int k = Convert.ToInt32(Console.ReadLine());

int pozitie = -1;
for (int i = 0; i < n; i++)
{
    if (vector[i] == k)
    {
        pozitie = i;
        break;
    }
}

Console.WriteLine("Prima pozitie pe care apare k este: " + pozitie);*/

/*Console.Write("Introdu numărul de elemente din vector: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Introdu elementul " + (i + 1) + ": ");
    vector[i] = Convert.ToInt32(Console.ReadLine());
}

int minPoz = 0, maxPoz = 0;
for (int i = 1; i < n; i++)
{
    if (vector[i] < vector[minPoz])
    {
        minPoz = i;
    }
    if (vector[i] > vector[maxPoz])
    {
        maxPoz = i;
    }
}

Console.WriteLine("Pozitia celui mai mic element este: " + minPoz);
Console.WriteLine("Pozitia celui mai mare element este: " + maxPoz);*/

// Ex 4

/*  Console.WriteLine("Introduceti lungimea sirului de elemente:");
  int n = Convert.ToInt32(Console.ReadLine());

  int[] vector = new int[n];

  for (int i = 0; i < n; i++)
  {
      Console.WriteLine("introdu elementul" + (i + 1) + ":");

  }
  int minVal = vector[0], maxVal = vector[0], minCount = 0, maxCount = 0;

  for (int i = 0; i < n; i++)
  {
      if (vector[i] < minVal)
      {
          minVal = vector[i];
          minCount = 1;
      }
      else if (vector[i] == minVal)
      {
          minCount++;
      }

      if (vector[i] > maxVal)
      {
          maxVal = vector[i];
          maxCount = 1;
      }
      else if (vector[i] == maxVal)
      {
          maxCount++;
      }
  }

  Console.WriteLine("Cea mai mica valoare este " + minVal + " si apare de " + minCount + " ori.");
  Console.WriteLine("Cea mai mare valoare este " + maxVal + " si apare de " + maxCount + " ori.");*/

// Ex 5


/*  List<int> vector = new List<int> { 1, 2, 3, 4, 5 };
  Console.WriteLine("Vectorul initial: " + String.Join(", ", vector));

  InsereazaValoare(vector, 10, 2);
  Console.WriteLine("Vectorul după inserare: " + String.Join(", ", vector));

static void InsereazaValoare(List<int> vector, int valoare, int pozitie)
{
  if (pozitie >= 0 && pozitie <= vector.Count)
  {
     vector.Insert(pozitie, valoare);
  }
  else
  {
     Console.WriteLine("Pozitia nu este valida.");
  }
}*/


// Ex 7

/* int[] vector = { 1, 2, 3, 4, 5, };
 Console.WriteLine("Vectorul initial:");
 AfisezaVector(vector);

 Array.Reverse(vector);
 Console.WriteLine("Vectorul inversat:");
 AfisezaVector(vector);


private static void AfisezaVector(int[] vector)
{


    foreach (var element in vector)
    {
     Console.Write(element + " ");
    }
     Console.WriteLine();

}*/

// Ex 8

/* int[] vector = { 1, 2, 3, 4, 5 };
 Console.WriteLine("Vectorul initial:");
 AfiseazaVector(vector);


 RotesteSpreStanga(vector);
 Console.WriteLine("Vectorul rotit spre stânga:");
 AfiseazaVector(vector);
}

static void RotesteSpreStanga(int[] vector)
{
 int primulElement = vector[0];
 int lungime = vector.Length;

 for (int i = 0; i < lungime - 1; i++)
 {
     vector[i] = vector[i + 1];
 }

 vector[lungime - 1] = primulElement;


}

static void AfiseazaVector(int[] vector)
{
 foreach (var element in vector)
 {
     Console.Write(element + " ");
 }
 Console.WriteLine();*/


//Ex 9

/* int[] vector = { 1, 2, 3, 4, 5 };

 int k = 2;

 Console.WriteLine("Vectorul initial: ");
 AfisareVector(vector);

 RotireStanga(vector, k);

 Console.WriteLine("\nVectorul rotit la stanga cu {0} pozitii: ", k);
 AfisareVector(vector);

}

static void RotireStanga(int[] vector, int k)
{
 int lungimeVector = vector.Length;
 int[] tampon = new int[k];
 Array.Copy(vector, tampon, k);
 Array.Copy(vector, k, vector, 0, lungimeVector - k);
 Array.Copy(tampon, 0, vector, lungimeVector - k, k);
}

static void AfisareVector(int[] vector)
{
 foreach (var element in vector)
 {
     Console.Write(element + " ");
 }
 Console.WriteLine();*/

// ex 10


/*int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


int k = 7;

int pozitie = CautareBinara(vector, k);

if (pozitie != -1)
{
    Console.WriteLine("Elementul {0} se afla la pozitia {1}.", k, pozitie);
}
else
{
    Console.WriteLine("Elementul {0} nu a fost gasit in vector.", k);
}
}

static int CautareBinara(int[] vector, int k)
{
int stanga = 0;
int dreapta = vector.Length - 1;

while (stanga <= dreapta)
{
    int mijloc = (stanga + dreapta) / 2;


    if (vector[mijloc] == k)
    {
        return mijloc;
    }

    else if (vector[mijloc] > k)
    {
        dreapta = mijloc - 1;
    }

    else
    {
        stanga = mijloc + 1;
    }
}
return -1;*/



//ex 11   

/*Console.Write("Introduceti numarul n: ");
int n = int.Parse(Console.ReadLine());

AfisareNumerePrime(n);
}

static void AfisareNumerePrime(int n)
{

bool[] estePrim = new bool[n + 1];
for (int i = 2; i <= n; i++)
{
    estePrim[i] = true;
}


for (int p = 2; p * p <= n; p++)
{
    if (estePrim[p] == true)
    {

        for (int i = p * p; i <= n; i += p)
        {
            estePrim[i] = false;
        }
    }
}


Console.WriteLine("Numerele prime mai mici sau egale cu {0} sunt:", n);
for (int i = 2; i <= n; i++)
{
    if (estePrim[i] == true)
    {
        Console.Write(i + " ");
    }
}*/

// ex 12

/*  int[] vector = { 64, 25, 12, 22, 11 };

  Console.WriteLine("Vectorul nesortat: ");
  AfisareVector(vector);

  SelectionSort(vector);

  Console.WriteLine("Vectorul sortat prin Selection Sort: ");
  AfisareVector(vector);
}

static void SelectionSort(int[] vector)
{
  int lungime = vector.Length;

  for (int i = 0; i < lungime - 1; i++)
  {

      int indiceMinim = i;
      for (int j = i + 1; j < lungime; j++)
      {
          if (vector[j] < vector[indiceMinim])
          {
              indiceMinim = j;
          }
      }


      Swap(ref vector[i], ref vector[indiceMinim]);
  }
}

static void Swap(ref int a, ref int b)
{
  int temp = a;
  a = b;
  b = temp;
}

static void AfisareVector(int[] vector)
{
  foreach (var element in vector)
  {
      Console.Write(element + " ");
  }
  Console.WriteLine();*/

// ex 13

/* int[] vector = { 64, 25, 12, 22, 11 };

 Console.WriteLine("Vectorul nesortat: ");
 AfisareVector(vector);

 SelectionSort(vector);

 Console.WriteLine("Vectorul sortat prin Selection Sort: ");
 AfisareVector(vector);
}

static void SelectionSort(int[] vector)
{
 int lungime = vector.Length;

 for (int i = 0; i < lungime - 1; i++)
 {

     int indiceMinim = i;
     for (int j = i + 1; j < lungime; j++)
     {
         if (vector[j] < vector[indiceMinim])
         {
             indiceMinim = j;
         }
     }


     Swap(ref vector[i], ref vector[indiceMinim]);
 }
}

static void Swap(ref int a, ref int b)
{
 int temp = a;
 a = b;
 b = temp;
}

static void AfisareVector(int[] vector)
{
 foreach (var element in vector)
 {
     Console.Write(element + " ");
 }
 Console.WriteLine();*/


// ex 14

/* int[] vector = { 1, 0, 5, 0, 3, 0, 9, 0, 0, 8 };

  Console.WriteLine("Vectorul initial: ");
  AfisareVector(vector);

  RearanjeazaZero(vector);

  Console.WriteLine("\nVectorul cu zerouri la sfarsit: ");
  AfisareVector(vector);
}

static void RearanjeazaZero(int[] vector)
{
  int pozitieZero = vector.Length - 1;


  for (int i = 0; i < pozitieZero; i++)
  {

      if (vector[i] != 0)
      {
          Swap(ref vector[i], ref vector[pozitieZero]);


          pozitieZero--;

          i--;
      }
  }
}

static void Swap(ref int a, ref int b)
{
  int temp = a;
  a = b;
  b = temp;
}

static void AfisareVector(int[] vector)
{
  foreach (var element in vector)
  {
      Console.Write(element + " ");
  }
  Console.WriteLine();*/


//ex 15


/* int[] vector = { 1, 2, 3, 2, 4, 5, 6, 5, 7, 8, 9, 9 };

 Console.WriteLine("Vectorul initial: ");
 AfisareVector(vector);

 EliminareDuplicate(vector);

 Console.WriteLine("\nVectorul fara elemente duplicate: ");
 AfisareVector(vector);
}

static void EliminareDuplicate(int[] vector)
{

 HashSet<int> elementeUnice = new HashSet<int>();

 int lungimeNoua = 0;


 for (int i = 0; i < vector.Length; i++)
 {
     if (elementeUnice.Add(vector[i]))
     {

         vector[lungimeNoua] = vector[i];
         lungimeNoua++;
     }
 }


 Array.Resize(ref vector, lungimeNoua);
}

static void AfisareVector(int[] vector)
{
 foreach (var element in vector)
 {
     Console.Write(element + " ");
 }
 Console.WriteLine();*/

// ex 16

/*  static int EuclideanGCD(int a, int b)
  {
      while (b != 0)
      {
          int temp = b;
          b = a % b;
          a = temp;
      }
      return a;
  }


  static int CalculateGCD(int[] numbers)
  {
      if (numbers.Length == 0)
      {
          throw new ArgumentException("Vectorul nu poate fi gol.");
      }

      int result = numbers[0];
      for (int i = 1; i < numbers.Length; i++)
      {
          result = EuclideanGCD(result, numbers[i]);
      }

      return result;
  }

  static void Main()
  {

      int[] vector = { 12, 18, 24, 36 };
      int gcd = CalculateGCD(vector);

      Console.WriteLine("Cel mai mare divizor comun al elementelor vectorului este: " + gcd);

  }*/


// ex 17


/*  Console.Write("Introduceți numărul în baza 10: ");
  int n = int.Parse(Console.ReadLine());

  Console.Write("Introduceți baza de conversie (1 < b < 17): ");
  int b = int.Parse(Console.ReadLine());


  if (b <= 1 || b >= 17)
  {
      Console.WriteLine("Baza trebuie să fie între 1 și 16.");
      return;
  }


  string result = ConvertToBase(n, b);
  Console.WriteLine($"Numărul {n} în baza {b} este: {result}");
}


static string ConvertToBase(int number, int targetBase)
{

  if (number == 0)
  {
      return "0";
  }


  char[] digits = "0123456789ABCDEF".ToCharArray();


  string result = "";
  while (number > 0)
  {
      int remainder = number % targetBase;
      result = digits[remainder] + result;
      number /= targetBase;
  }

  return result;*/

// ex 18

/*  Console.Write("Introduceti gradul polinomului (n): ");
  int n = int.Parse(Console.ReadLine());


  double[] coeficienti = new double[n + 1];
  for (int i = 0; i <= n; i++)
  {
      Console.Write($"Introduceti coeficientul pentru x^{i}: ");
      coeficienti[i] = double.Parse(Console.ReadLine());
  }


  Console.Write("Introduceti valoarea lui x: ");
  double x = double.Parse(Console.ReadLine());


  double rezultat = EvaluaPolinom(coeficienti, x);
  Console.WriteLine($"Valoarea polinomului în punctul {x} este: {rezultat}");
}


static double EvaluaPolinom(double[] coeficienti, double x)
{
  double rezultat = 0.0;

  for (int i = 0; i < coeficienti.Length; i++)
  {
      rezultat += coeficienti[i] * Math.Pow(x, i);
  }

  return rezultat;*/

// 19

/*   Console.WriteLine("Introduceti vectorul s:");
   int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


   Console.WriteLine("Introduceti vectorul p:");
   int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


   int aparitii = NumarAparitii(s, p);
   Console.WriteLine($"Vectorul p apare în vectorul s de {aparitii} ori.");
}


static int NumarAparitii(int[] s, int[] p)
{
   int m = s.Length;
   int n = p.Length;


   int hashP = 0;
   foreach (int num in p)
   {
       hashP = hashP * 101 + num;
   }


   int hashS = 0;
   for (int i = 0; i < n; i++)
   {
       hashS = hashS * 101 + s[i];
   }

   int aparitii = 0;


   for (int i = 0; i <= m - n; i++)
   {
       if (hashS == hashP)
       {

           bool match = true;
           for (int j = 0; j < n; j++)
           {
               if (s[i + j] != p[j])
               {
                   match = false;
                   break;
               }
           }

           if (match)
           {
               aparitii++;
           }
       }


       if (i < m - n)
       {
           hashS = hashS * 101 - s[i] * (int)Math.Pow(101, n - 1) + s[i + n];
       }
   }

   return aparitii;*/


// ex 20

/* Console.Write("Introduceti primul șir de mărgele (s1):");
  string s1 = Console.ReadLine();

  Console.Write("Introduceti al doilea șir de mărgele (s2):");
  string s2 = Console.ReadLine();


  int numarSuprapuneri = NumarSuprapuneri(s1, s2);
  Console.WriteLine($"Numărul de suprapuneri între șirurile de mărgele este: {numarSuprapuneri}");
}


static int NumarSuprapuneri(string s1, string s2)
{
  int numarSuprapuneri = 0;
  int m = s1.Length;
  int n = s2.Length;


  for (int i = 0; i < m; i++)
  {

      for (int j = 0; j < n; j++)
      {
          bool suprapunere = true;

          for (int k = 0; k < Math.Min(m - i, n - j); k++)
          {
              if (s1[i + k] == s2[j + k])
              {
                  suprapunere = false;
                  break;
              }
          }

          if (suprapunere)
          {
              numarSuprapuneri++;
          }
      }
  }

  return numarSuprapuneri;*/



// ex 21
