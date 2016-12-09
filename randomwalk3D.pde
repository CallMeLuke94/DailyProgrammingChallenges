import peasy.*;
PeasyCam camera;

boolean showBox = false;
int x = 0;
int y = 0;
int z = 0;
int step = 2;
int side = 2;
int boxSize = 10000;
ArrayList<PVector> points = new ArrayList<PVector>();

void setup() {
  size(700, 600, P3D);
  background(255);
  camera = new PeasyCam(this, 0, 0, 0, 200);
} 

void draw() {
  background(255);
  
  //draw whole path
  stroke(0);
  noFill();
  beginShape();
  for (PVector p : points){
    vertex(p.x, p.y, p.z);
  }
  endShape();
  
  //draw box at end of path
  pushMatrix();
  translate(x, y, z);
  noStroke();
  fill(0);
  box(side);
  popMatrix();

  //flip three coins
  float xinc = random(0, 2);
  float yinc = random(0, 2);
  float zinc = random(0, 2);

  //increment or decrement x and y
  if (xinc < 1) {
    x -= step;
  } else {
    x += step;
  }
  if (yinc < 1) {
    y -= step;
  } else {
    y += step;
  }
  if (zinc < 1) {
    z -= step;
  } else {
    z += step;
  }
  
  //constrain values
  x = constrain(x, -boxSize, boxSize);
  y = constrain(y, -boxSize, boxSize);
  z = constrain(z, -boxSize, boxSize);
  
  //add new point to list
  points.add(new PVector(x, y, z));
  
  if (showBox) {
    noFill();
    stroke(0);
    box(boxSize/2);
  }
}

void keyPressed(){
  showBox = !showBox;
}