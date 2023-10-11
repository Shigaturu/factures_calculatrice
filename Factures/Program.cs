const float _plafondTTC = 36800;
float sommeFacture = 0;
bool done2 = false;

float nbFacture = getNumberFromUser();

while (!done2)
{
    try
    {
        for (int i = 0; i < nbFacture; i++)
        {
            Console.WriteLine("Quel est le montant de la facture " + i);
            float prixFacture = Convert.ToInt32(Console.ReadLine());
            sommeFacture += prixFacture;

        }
        done2 = true;
    }

    catch
    {
        Console.WriteLine("Saisie incorect");

    }
}

Console.WriteLine("Somme des factures en brut annuel " + sommeFacture + "€");
Console.WriteLine("Somme des factures en net annuel " + getNet(sommeFacture) + "€");
Console.WriteLine("Facture par mois net " + getMensuel(getNet(sommeFacture)) + "€");
Console.WriteLine("Facture par mois brut " + getMensuel(sommeFacture) + "€");

if (sommeFacture > _plafondTTC)
{
    Console.WriteLine("Le plafond brut est dépassé de " + (sommeFacture - _plafondTTC) + "€");
}


float getNet(float brut)
{
    return brut * (float)0.75;
}

float getMensuel(float annuel)
{
    return annuel / (float)12;
}

float getNumberFromUser()
{
    float nbFacture = 0;
    bool done = false;

    while (!done)
    {
        try
        {
            Console.WriteLine("Entrez le nombre de factures");
            nbFacture = Convert.ToInt32(Console.ReadLine());
            done = true;

        }
        catch
        {
            Console.WriteLine("Saisie incorect");

        }
    }
    return nbFacture;
}