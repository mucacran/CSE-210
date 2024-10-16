using System;

class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number){
        _top = number;
        _bottom = 1;
    }

    public Fraction(int top,int bottom){
        _top = top;
        _bottom = bottom;
    }

    //auxiliares
    public int getTop(){
        return _top;
    }

    public void setTop(int top){
        _top = top;
    }

    public int getBottom(){
        return _bottom;
    }

    public void setBottom(int bottom){
        _bottom = bottom;
    }

    //aciones
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }


}