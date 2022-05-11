string[] arraystr = new string[] { "Коля", "Оля", "Пашка", "Руслан", "Олег", "Денис", "Миша" };
Random rand = new Random();
int i = rand.Next(0,6);
int x = rand.Next(0,6);
int y = rand.Next(0,6);

string[] arraystr3 = new string[] {arraystr[i], arraystr[x], arraystr[y]};

for (int z = 0; z < arraystr3.Length; z++)
{
    Console.WriteLine(arraystr3[z]);
}
