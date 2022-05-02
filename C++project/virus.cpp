#include <iostream>
#include<conio.h>
using namespace std;
class Virus
{

float a,b;

   public:
    virtual  void GetMortalityRate()
    {
          cout<< "Enter  The Total Virus Cases";
   cin>>a;
  cout<<"Enter The Total Virus Deaths";
  cin>>b;
        std::cout << "The MortalityRate of Virus : " << (b/a)*100<<"%"<<std::endl;
    }
};
class CovidVirus: public Virus
{


   float a,b;
    public:
    void GetMortalityRate()
    {
           cout<< "Enter  The Total CovidVirus Cases";
   cin>>a;
  cout<<"Enter The Total CovidVirus Deaths";
  cin>>b;
 std::cout << "The MortalityRate of Virus : " << (b/a)*100<<"%"<<std::endl;    }
};
class HIVVirus: public Virus
{
float a,b;


    public:
    void GetMortalityRate()
    {
            cout<< "Enter  The Total HIVVirus Cases";
   cin>>a;
  cout<<"Enter The Total HIVVirus Deaths";
  cin>>b;
 std::cout << "The MortalityRate of HIVVirus : " << (b/a)*100<<"%"<<std::endl;    }
};
class BirdFlue: public Virus
{

   float a,b;

    public:
    void GetMortalityRate()
    {
            cout<< "Enter  The Total BirdFlue Cases";
   cin>>a;
  cout<<"Enter The Total BirdFlue Deaths";
  cin>>b;
 std::cout << "The MortalityRate of BirdFlue : " << (b/a)*100<<"%"<<std::endl;    }
};

int main()
{
   int ch;


 std::cout<<"1.Virus\n2.CovidVirus\n3.HivVirus\n4.BirdFlue "<<std::endl;
  std::cout<<"enter the choice      "<<std::endl;
    std::cin>>ch;

    Virus *a;
  switch(ch)
  {
      case 1:{
      Virus p;
       a = &p;
   a->GetMortalityRate();
      break;}

  case 2:{
      CovidVirus c;
       a = &c;
   a->GetMortalityRate();
      break;}

  case 3:{
      HIVVirus h;
       a = &h;
   a->GetMortalityRate();
      break;}

case 4:{
      BirdFlue e;
       a = &e;
   a->GetMortalityRate();
      break;}




}


getchar();
    return 0;
}

