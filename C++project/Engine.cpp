#include <iostream>
#include<conio.h>
using namespace std;
class Engine
{

float a,b;

   public:
    virtual  void GetEfficiency()
    {
          cout<< "Enter  the Engine input";
   cin>>a;
  cout<<"Enter the  Engine output";
  cin>>b;
        std::cout << "The Efficiency of Engine : " << (b/a)*100<<"%"<<std::endl;
    }
};
class InternalCombustineEngine: public Engine
{


   float a,b;
    public:
    void GetEfficiency()
    {
           cout<< "Enter  the InternalCombustineEngine input";
   cin>>a;
  cout<<"Enter the  InternalCombustineEngine output";
  cin>>b;
        std::cout << "The Efficiency of InternalCombustineEngine: "  << (b/a)*100<<"%"<<std::endl;
    }
};
class ExternalCombustineEngine: public Engine
{
float a,b;


    public:
    void GetEfficiency()
    {
             cout<< "Enter  the ExternalCombustineEngine input";
   cin>>a;
  cout<<"Enter the  ExternalCombustineEngine output";
  cin>>b;
        std::cout << "The Efficiency of ExternalCombustineEngine  : "  << (b/a)*100<<"%"<<std::endl;
    }
};
class PetrolEngine: public Engine
{

   float a,b;

    public:
    void GetEfficiency()
    {
            cout<< "Enter  the PetrolEngine input";
   cin>>a;
  cout<<"Enter the  PetrolEngine output";
  cin>>b;
        std::cout << "The Efficiency of PetrolEngine : " << (b/a)*100<<"%"<<std::endl;
    }
};
class SteamEngine: public Engine
{

   float a,b;

    public:
    void GetEfficiency()

    {
            cout<< "Enter  the SteamEngine input";
   cin>>a;
  cout<<"Enter the  SteamEngine output";
  cin>>b;
        std::cout << "The Efficiency of SteamEngine : " << (b/a)*100<<"%"<<std::endl;
    }
};
class DieselEngine: public Engine
{

   float a,b;

    public:
    void GetEfficiency()
    {
            cout<< "Enter  the DieselEngine: input";
   cin>>a;
  cout<<"Enter the  DieselEngine: output";
  cin>>b;
        std::cout << "The Efficiency of DieselEngine : " << (b/a)*100<<"%"<<std::endl;
    }
};
int main()
{
   int ch;


 std::cout<<"1.Engine\n2.InternalCombustineEngine\n3. ExternalCombustineEngine \n4. PetrolEngine\n5. DieselEngine\n6. SteamEngine"<<std::endl;
  std::cout<<"enter the choice      "<<std::endl;
    std::cin>>ch;

    Engine *a;
  switch(ch)
  {
  case 1:{
      Engine En;
       a = &En;
   a->GetEfficiency();
      break;}

  case 2:{
      InternalCombustineEngine i;
       a = &i;
   a->GetEfficiency();
      break;}

case 3:{
      ExternalCombustineEngine e;
       a = &e;
   a->GetEfficiency();
      break;}

case 4:{
      PetrolEngine p;
       a = &p;
   a->GetEfficiency();
      break;}


case 5:{
     DieselEngine d;
       a = &d;
   a->GetEfficiency();
      break;}

case 6:{
     SteamEngine s;
       a = &s;
   a->GetEfficiency();
      break;}
}

cin>>ch;
getchar();
    return 0;
}

