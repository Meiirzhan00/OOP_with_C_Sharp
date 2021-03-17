#include <iostream>
#include <string>
using namespace std;

int main() {
  int n;
  cout << "Input number : ";
  cin >> n;
  int result=0;
  int abs_n=abs(n);
  while(abs_n != 0){
    
    int reminder=abs_n%10;
    abs_n=abs_n/10;
    int temp=result*10+reminder;
    result=temp;
    
  }

  if (n<0){
    result = -1*result;
  }
  
  cout << result <<endl;
  
}
