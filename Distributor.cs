using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Distributor
{
    private String name;
    private int phoneNumber;
    private int officeNumber;
    private String street;
    private String city;
    private String state;
    private int zipcode;
    private String country;
    private int frequencyOfPickUp;
    private String lastUpdatedBy;
    private DateTime lastUpdated;
    private int isDeleted;

    public Distributor(String name, int phoneNumber, int officeNumber, String street, String city, String state, int zipcode,
        String country, int frequencyOfPickUp, String lastUpdatedBy, DateTime lastUpdated, int isDeleted)
    {
        setName(name);
        setPhoneNumber(phoneNumber);
        setOfficeNumber(officeNumber);
        setStreet(street);
        setCity(city);
        setState(state);
        setZip(zipcode);
        setCountry(country);
        setFrequencyOfPickUp(frequencyOfPickUp);
        setLastUpdatedBy(lastUpdatedBy);
        setLastUpdated(lastUpdated);
        setIsDeleted(isDeleted);

    }

    public void setName(String name)
    {
        this.name = name;
    }

    public String getName()
    {
        return this.name;
    }

    public void setPhoneNumber(int phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public int getPhoneNumber()
    {
        return this.phoneNumber;
    }

    public void setOfficeNumber(int officeNumber)
    {
        this.officeNumber = officeNumber;
    }

    public int getOfficeNumber()
    {
        return this.officeNumber;
    }

    public void setStreet(String street)
    {
        this.street = street;
    }

    public String getStreet()
    {
        return this.street;
    }

    public void setCity(String city)
    {
        this.city = city;
    }

    public String getCity()
    {
        return this.city;
    }

    public void setState(String state)
    {
        this.state = state;
    }

    public String getState()
    {
        return this.state;
    }

    public void setZip(int zipcode)
    {
        this.zipcode = zipcode;
    }

    public int getZip()
    {
        return this.zipcode;
    }

    public void setCountry(String country)
    {
        this.country = country;
    }

    public String getCountry()
    {
        return this.country;
    }

    public void setFrequencyOfPickUp(int frequencyOfPickUp)
    {
        this.frequencyOfPickUp = frequencyOfPickUp;
    }

    public int getFrequencyOfPickUp()
    {
        return this.frequencyOfPickUp;
    }

    public void setLastUpdatedBy(String lastUpdatedBy)
    {
        this.lastUpdatedBy = lastUpdatedBy;
    }

    public String getLastUpdatedBy()
    {
        return this.lastUpdatedBy;
    }

    public void setLastUpdated(DateTime lastUpdated)
    {
        this.lastUpdated = lastUpdated;
    }

    public DateTime getlastUpdated()
    {
        return this.lastUpdated;
    }

    public void setIsDeleted(int isDeleted)
    {
        this.isDeleted = isDeleted;
    }

    public int getIsDeleted()
    {
        return this.isDeleted;
    }
}
