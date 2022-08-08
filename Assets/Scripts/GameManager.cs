using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject[] car;

    //Civic Parts
    public Material[] paintCivic;
    public GameObject[] bodyCivic;
    public GameObject[] spoilerCivic;
    public GameObject[] rimCivic;

    public GameObject[] windowCivic;
    public Material[] windowpaintCivic;
    public bool windowsTintedCivic;

    public GameObject[] bodykitCivicNormal;
    public GameObject[] bodykitCivicModified;
    public bool modifiedCivic;

    public GameObject[] frontLightCivic;
    public GameObject[] backLightCivic;
    public Material[] lightOnCivic;
    public Material[] lightOffCivic;
    public bool lightCivic;

    public GameObject[] indicatorCivic;
    public GameObject[] indicatorSideCivic;
    public Material[] indicatorOnOffCivic;
    public bool indicateCivic;

    public Rotator rotatorCivic;

    //Swift Parts
    public Material[] paintSwift;
    public GameObject[] bodySwift;
    public GameObject[] spoilerSwift;
    public GameObject[] rimSwift;

    public GameObject[] windowSwift;
    public bool windowsTintedSwift;

    public GameObject[] kitSwift;
    public GameObject[] bodykitSwift;

    public GameObject[] lightSwift;
    public GameObject[] indicatorSwift;

    //Game Music
    public AudioSource backGroundMusic;
    public bool Music;

    //Car Name
    public Text carName;

    //Car UI
    public GameObject CivicPanel;
    public GameObject SwiftPanel;

    // Start is called before the first frame update
    void Start()
    {
        Music = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Car Paint
    public void selectPaint(string paintName)
    {
        GameObject ActiveCar = GetActiveCar(car);

        if (ActiveCar != null)
        {
            if (ActiveCar.name == "Civic")
            {
                changePaint(paintName, bodyCivic, paintCivic);
            }
            else if(ActiveCar.name == "Swift")
            {
                changePaint(paintName, bodySwift, paintSwift);
            }
            else
            {
                Debug.Log("Add more if else condition to selectPaint function");
            }
        }
    }

    private void changePaint(string paintName, GameObject[] carBody, Material[] paint)
    {
        if (paintName == "Black")
        {
            foreach(GameObject item in carBody)
            {
                item.GetComponent<MeshRenderer>().material = paint[0];
            }
        }
        else if (paintName == "Blue")
        {
            foreach (GameObject item in carBody)
            {
                item.GetComponent<MeshRenderer>().material = paint[1];
            }
        }
        else if (paintName == "Red")
        {
            foreach (GameObject item in carBody)
            {
                item.GetComponent<MeshRenderer>().material = paint[2];
            }
        }
        else if (paintName == "White")
        {
            foreach (GameObject item in carBody)
            {
                item.GetComponent<MeshRenderer>().material = paint[3];
            }
        }
        else if (paintName == "Silver")
        {
            foreach (GameObject item in carBody)
            {
                item.GetComponent<MeshRenderer>().material = paint[4];
            }
        }
        else
        {
            Debug.Log("Please select a valid color");
        }
    }

    //Car Rotate
    public void CarRotate()
    {
        if (rotatorCivic.speedMultiplier==0.1f)
        {
            rotatorCivic.speedMultiplier = 0;
        }
        else
        {
            rotatorCivic.speedMultiplier = 0.1f;
        }
    }

    //Car Rim
    public void carRim(int RimNumber)
    {
        GameObject ActiveCar = GetActiveCar(car);

        if (ActiveCar != null)
        {
            if (ActiveCar.name == "Civic")
            {
                foreach (GameObject item in rimCivic)
                {
                    item.SetActive(false);
                }

                rimCivic[RimNumber].SetActive(true);
            }
            else if (ActiveCar.name == "Swift")
            {
                foreach (GameObject item in rimSwift)
                {
                    item.SetActive(false);
                }

                rimSwift[RimNumber].SetActive(true);
            }
            else
            {
                Debug.Log("Add more if else condition to carRim function");
            }
        }
    }

    //Car Spoiler
    public void carSpoiler(int spoilerNumber)
    {
        GameObject ActiveCar = GetActiveCar(car);

        if (ActiveCar != null)
        {
            if (ActiveCar.name == "Civic")
            {
                foreach (GameObject item in spoilerCivic)
                {
                    item.SetActive(false);
                }

                spoilerCivic[spoilerNumber].SetActive(true);
            }
            else if (ActiveCar.name == "Swift")
            {
                Debug.Log("Swift not added");
            }
            else
            {
                Debug.Log("Add more if else condition to selectPaint function");
            }
        }
    }

    //Car lights
    public void carLights()
    {
        GameObject ActiveCar = GetActiveCar(car);

        if (ActiveCar != null)
        {
            if (ActiveCar.name == "Civic")
            {
                lightCivic = !lightCivic;
                if (lightCivic)
                {
                    foreach (GameObject item in frontLightCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = lightOnCivic[0];
                    }

                    foreach (GameObject item in backLightCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = lightOnCivic[1];
                    }
                }
                else
                {
                    foreach (GameObject item in frontLightCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = lightOffCivic[0];
                    }

                    foreach (GameObject item in backLightCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = lightOffCivic[1];
                    }
                }
            }
            else if (ActiveCar.name == "Swift")
            {
                Debug.Log("Swift not added");
            }
            else
            {
                Debug.Log("Add more if else condition to selectPaint function");
            }
        }
    }

    //Car Indicator
    public void carIndicator()
    {
        GameObject ActiveCar = GetActiveCar(car);

        if (ActiveCar != null)
        {
            if (ActiveCar.name == "Civic")
            {
                indicateCivic = !indicateCivic;
                if (indicateCivic)
                {
                    foreach (GameObject item in indicatorCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = indicatorOnOffCivic[0];
                    }

                    foreach (GameObject item in indicatorSideCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = indicatorOnOffCivic[1];
                    }
                }
                else
                {
                    foreach (GameObject item in indicatorCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = indicatorOnOffCivic[2];
                    }

                    foreach (GameObject item in indicatorSideCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = indicatorOnOffCivic[2];
                    }
                }
            }
            else if (ActiveCar.name == "Swift")
            {
                Debug.Log("Swift not added");
            }
            else
            {
                Debug.Log("Add more if else condition to selectPaint function");
            }
        }
    }

    //Car Windows
    public void carWindows()
    {
        GameObject ActiveCar = GetActiveCar(car);

        if (ActiveCar != null)
        {
            if (ActiveCar.name == "Civic")
            {
                windowsTintedCivic = !windowsTintedCivic;
                if (windowsTintedCivic)
                {
                    foreach (GameObject item in windowCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = windowpaintCivic[0];
                    }
                }
                else
                {
                    foreach (GameObject item in windowCivic)
                    {
                        item.GetComponent<MeshRenderer>().material = windowpaintCivic[1];
                    }
                }
            }
            else if (ActiveCar.name == "Swift")
            {
                windowsTintedSwift = !windowsTintedSwift;
                if (windowsTintedSwift)
                {
                    foreach (GameObject item in windowSwift)
                    {
                        item.GetComponent<MeshRenderer>().material = windowpaintCivic[0];
                    }
                }
                else
                {
                    foreach (GameObject item in windowSwift)
                    {
                        item.GetComponent<MeshRenderer>().material = windowpaintCivic[1];
                    }
                }
            }
            else
            {
                Debug.Log("Add more if else condition to selectPaint function");
            }
        }
    }

    //Car BodyKit
    public void carBodyKit()
    {
        GameObject ActiveCar = GetActiveCar(car);

        if (ActiveCar != null)
        {
            if (ActiveCar.name == "Civic")
            {
                modifiedCivic = !modifiedCivic;
                if (modifiedCivic)
                {
                    foreach (GameObject item in bodykitCivicNormal)
                    {
                        item.SetActive(false);
                    }

                    foreach (GameObject item in bodykitCivicModified)
                    {
                        item.SetActive(true);
                    }
                }
                else
                {
                    foreach (GameObject item in bodykitCivicModified)
                    {
                        item.SetActive(false);
                    }

                    foreach (GameObject item in bodykitCivicNormal)
                    {
                        item.SetActive(true);
                    }
                }
            }
            else if (ActiveCar.name == "Swift")
            {
                Debug.Log("Swift not added");
            }
            else
            {
                Debug.Log("Add more if else condition to selectPaint function");
            }
        }
    }

    //Select Car
    public void SelectCar()
    {
        if (GetActiveCar(car).name == "Civic")
        {
            //Activating Swift
            CivicPanel.SetActive(false);
            SwiftPanel.SetActive(true);
            car[0].SetActive(false);
            car[1].SetActive(true);
            //carName.text = "2018 | Suzuki Swift";
        }
        else
        {
            //Activating Civic
            CivicPanel.SetActive(true);
            SwiftPanel.SetActive(false);
            car[1].SetActive(false);
            car[0].SetActive(true);
            //carName.text = "2021 | Honda Civic";
        }
    }

    //Game Music
    public void ToggleMusic()
    {
        Music = !Music;
        if (Music)
        {
            backGroundMusic.gameObject.SetActive(true);
        }
        else
        {
            backGroundMusic.gameObject.SetActive(false);
        }
    }

    //Application Quit
    public void Quit()
    {
        Application.Quit();
    }

    public GameObject GetActiveCar(GameObject[] car)
    {
        foreach(GameObject item in car)
        {
            if (item.activeSelf)
            {
                return item;
            }
        }
        
        return null;
    }
}
