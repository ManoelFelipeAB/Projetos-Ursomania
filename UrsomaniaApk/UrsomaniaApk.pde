import processing.sound.*;
import processing.video.*;
import ddf.minim.*;

PImage img1;
PImage img2;
PImage img3;
PImage img4;
PImage img5;
PImage img6;
PImage img7;
PImage img8;
PImage img9;
PImage img10;
PImage img11;
PImage voltarinicio;
Movie myMovie;
SoundFile son;
SoundFile movie;

void setup() {
  // dimensão da tela, criando variaveis para inserir o movie e sound.

  size(1280, 720);
  background(img1 = loadImage ("capa.jpg"));
  son = new SoundFile(this, "sons.mp3");
  son.play();
  myMovie = new Movie(this, "videoursos.mp4");
  img1 = loadImage("capa.jpg");
  movie = new SoundFile(this, "moviesound.mp3");
}
// void para leitura do filme
void movieEvent(Movie myMovie) {
  myMovie.read();
}
void draw() {
  // condições para que ao clicar em tais coordenadas, redirecionar a diferentes blackgrounds
  if (mousePressed && (mouseButton == LEFT) && mouseX>760 && mouseX<1010 && mouseY>120 && mouseY<180) {
    clear();
    background(img2 = loadImage("resumo1.png"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>108 && mouseX<358 && mouseY>572 && mouseY<652){ 
    clear();
    background(img3 = loadImage("ursopardo.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>50 && mouseY<105){ 
    clear();
    background(img3 = loadImage("ursopardo.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>115 && mouseY<170) {
    clear();
    background(img4 = loadImage("ursopolar.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>180 && mouseY<235) {
    clear();
    background(img5 = loadImage("ursopanda.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>245 && mouseY<300) {
    clear();
    background(img6 = loadImage("ursoamericano.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>310 && mouseY<365) {
    clear();
    background(img7 = loadImage("ursoasiatico.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>375 && mouseY<430) {
    clear();
    background(img8 = loadImage("ursomalaio1.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>440 && mouseY<495) {
    clear();
    background(img9 = loadImage("ursobeicudo.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>505 && mouseY<560) {
    clear();
    background(img10 = loadImage("ursooculos.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>1054 && mouseX<1234 && mouseY>570 && mouseY<625) {
    clear();
    background(img10 = loadImage("capa.jpg"));}
  if (mousePressed && (mouseButton == LEFT) && mouseX>760 && mouseX<1010 && mouseY>260 && mouseY<310) {
    clear();
    background(img10 = loadImage("creditosgerais.jpg"));}
   else if (mousePressed && (mouseButton == LEFT) && mouseX>500 && mouseX<700 && mouseY>608 && mouseY<668) {
    clear();
    background(img10 = loadImage("capa.jpg"));}
    // condição para que clicando em tais coordenadas, dar play no video.
   if (mousePressed && (mouseButton == LEFT) && mouseX>760 && mouseX<1010 && mouseY>190 && mouseY<250) {
    clear();
    size(1280, 720);
    son.stop();
    movie.play();
    myMovie.play();}
    image(myMovie, 0, 0);
    // movie para e retorna a tela principal
   if (mousePressed && (mouseButton == LEFT) && mouseX>0 && mouseX<200 && mouseY>0 && mouseY<70) {
     clear();
     movie.stop();
     myMovie.stop();
     background(img1 = loadImage("capa.jpg"));
     image(img1,0 ,0);}
 

     
     
   
         
}

   
    

 
