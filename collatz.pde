float scl = 2;
int total = 100000;
int r = 5;
int zero;

void setup() {
  size(1800, 900);
  zero = height - 10;
  
  background(#C7FCF8);
  strokeWeight(1);
  stroke(200);
  for (int i = 1; i < 11; i++)
    line(0, zero - i * 50 * scl, width, zero - i * 50 * scl);
  stroke(0);
  line(0, zero, width, zero);
  
  noLoop();
}

void draw() {
  stroke(0);
  strokeWeight(2);
  for (int i = 1; i < total; i++)
    point(i * width/total, zero - collatz(i) * scl);
}

int collatz(int n) {
  int count = 0;
  while (n != 1) {
      if (n % 2 == 0)
          n /= 2;
      else
          n = (n * 3) + 1;
      count++;
  }
  return count;
}