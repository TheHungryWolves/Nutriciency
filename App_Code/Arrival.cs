using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Arrival
{
    private String UPC;
    private String arrivalDate;
    private String expirationDate;
    private int quantity;
    private double weight;
    private String lastUpdatedBy;
    private String lastUpdated;
    private int donorID;

    public Arrival()
    {
        setUPC("");
        setArrivalDate("");
        setExpirationDate("");
        setQuantity(0);
        setWeight(0.0);
        setLastUpdatedBy("");
        setLastUpdated("");
        setDonorID(0);
    }

    public Arrival(String upc, String arrivalDate, String expirationDate, int quantity, double weight,
        String lastUpdatedBy, String lastUpdated, int donorID)
    {
        setUPC(upc);
        setArrivalDate(arrivalDate);
        setExpirationDate(expirationDate);
        setQuantity(quantity);
        setWeight(weight);
        setLastUpdatedBy(lastUpdatedBy);
        setLastUpdated(lastUpdated);
        setDonorID(donorID);
    }

    public void setUPC(string upc)
    {
        this.UPC = upc;
    }

    public void setArrivalDate(String arrDate)
    {
        this.arrivalDate = arrDate;
    }

    public void setExpirationDate(String expDate)
    {
        this.expirationDate = expDate;
    }

    public void setQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public void setWeight(double weight)
    {
        this.weight = weight;
    }

    public void setLastUpdatedBy(string lastUpdatedBy)
    {
        this.lastUpdatedBy = lastUpdatedBy;
    }

    public void setLastUpdated(string lastUpdated)
    {
        this.lastUpdated = lastUpdated;
    }

    public void setDonorID(int donorID)
    {
        this.donorID = donorID;
    }

    public String getUPC()
    {
        return this.UPC;
    }

    public String getArrivalDate()
    {
        return this.arrivalDate;
    }

    public String getExpirationDate()
    {
        return this.expirationDate;
    }

    public int getQuantity()
    {
        return this.quantity;
    }

    public double getWeight()
    {
        return this.weight;
    }

    public String getLastUpdatedBy()
    {
        return this.lastUpdatedBy;
    }

    public String getLastUpdated()
    {
        return this.lastUpdated;
    }

    public int getDonorID()
    {
        return this.donorID;
    }
}