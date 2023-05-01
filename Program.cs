bool Target = false;

Console.WriteLine("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= 9; i += 1)
{
    if (x % i == 0 && x != i)
    {
        Target=true;
        
        break;
        

    }
    

}

if (Target == true)
{

    for(int h=1;Target!=false;h+=1)
    {
        string num = h.ToString();
        int siz = num.Length;
        int r = 0;
        int predfin = 1;

        while(r != siz)
        {
            foreach (char c in num)
            {
                int numint= (int)Char.GetNumericValue(c);
                predfin *= numint;
                r += 1;
                if (predfin == x)
                {
                    Console.WriteLine("Ansver="+h);
                    Target = false;
                    break;
                }
            }

        }
               
    }
}
else
{
    Console.WriteLine("Error404");
}




































