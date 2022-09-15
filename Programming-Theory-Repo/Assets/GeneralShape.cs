using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GeneralShape
{
   protected  GeneralShape(float mass)
    {
        this._mass = mass;
    }

    protected float _mass; //Encapsulation
    public float mass { get { return _mass; } }
    public float posX { get; set; } = 0.0f;

    public abstract void Move(); //Abstraction
}

public class Sphere : GeneralShape //Inheritance
{
    public float radius { get; private set; } //Encapsulation (private)
    public Sphere(float mass,float radius):base(mass) //Inheritance(base)
    {
        this.radius = radius;
    }
    public override void Move() //Polymorphism
    {
        this.Roll();
    }

    private void Roll()
    {
        posX +=  this.radius * 4 * Mathf.PI;
    }

    public override string ToString()
    {
        return "Sphere { mass:" +this.mass + ", posX:"+this.posX+ " radius:"+this.radius + "}";
    }
}
public class Cube : GeneralShape  //Inheritance
{
    public float side { get; private set; } //Encapsulation (private)
    public Cube(float mass, float side) : base(mass) //Inheritance(base)
    {
        this.side = side;
    }
    public override void Move() //Polymorphism
    {
        this.Tilt();
    }
    private void Tilt()
    {
        posX += 2* this.side;
    }
    public override string ToString()
    {
        return "Sphere { mass:" + this.mass + ", posX:" + this.posX + " side:" + this.side + "}";
    }

}
public class Cylinder : GeneralShape  //Inheritance
{
    public float side { get; private set; } //Encapsulation (private)
    public float radius { get; private set; } //Encapsulation (private)
    public Cylinder(float mass, float radius, float side) : base(mass) //Inheritance(base)
    {
        this.radius = radius;
        this.side = side;
    }
    public override void Move() //Polymorphism
    {
        this.RollAndTilt();
    }
    private void RollAndTilt()
    {
        posX += this.side + this.radius * 2 * Mathf.PI;
    }

    public override string ToString()
    {
        return "Sphere { mass:" + this.mass + ", posX:" + this.posX + " radius:" + this.radius + " side:" + this.side + "}";
    }

}

