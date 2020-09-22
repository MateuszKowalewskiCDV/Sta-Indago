using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImOnMyWayClient : MonoBehaviour
{
    private int choosenChair;

    private Vector3 _choosenChairDestination;

    public float speed;
    private float step;

    public GameObject SceneController;
    public GameObject order;
    public GameObject eToInteract;
    public GameObject VectorA, VectorA1, VectorA2, VectorA3, VectorB, VectorC, VectorD, VectorD1, VectorD2, VectorD3, VectorE, VectorE1, VectorE2, VectorE3, VectorE4;

    private bool _onPlace, _aCheck, _bCheck, _cCheck, _dCheck, _eCheck; 

    void Start()
    {
        _onPlace = false;
        _aCheck = false;
        _bCheck = false;
        _cCheck = false;
        _dCheck = false;
        _eCheck = false;

        step = speed * Time.deltaTime;
        choosenChair = Random.Range(0, 30);

        VectorA = GameObject.FindGameObjectWithTag("WaypointA");
        VectorB = GameObject.FindGameObjectWithTag("WaypointB");
        VectorC = GameObject.FindGameObjectWithTag("WaypointC");
        VectorD = GameObject.FindGameObjectWithTag("WaypointD");
        VectorE = GameObject.FindGameObjectWithTag("WaypointE");

        VectorA1 = GameObject.FindGameObjectWithTag("WaypointA1");
        VectorA2 = GameObject.FindGameObjectWithTag("WaypointA2");
        VectorA3 = GameObject.FindGameObjectWithTag("WaypointA3");

        VectorD1 = GameObject.FindGameObjectWithTag("WaypointD1");
        VectorD2 = GameObject.FindGameObjectWithTag("WaypointD2");
        VectorD3 = GameObject.FindGameObjectWithTag("WaypointD3");

        VectorE1 = GameObject.FindGameObjectWithTag("WaypointE1");
        VectorE2 = GameObject.FindGameObjectWithTag("WaypointE2");
        VectorE3 = GameObject.FindGameObjectWithTag("WaypointE3");
        VectorE4 = GameObject.FindGameObjectWithTag("WaypointE4");

        SceneController = GameObject.FindGameObjectWithTag("SceneController");

        ChairsAvability sc = SceneController.GetComponent<ChairsAvability>();
        _choosenChairDestination = sc.CheckMyChair(choosenChair);
    }

    private void Update()
    {
        if(transform.position == _choosenChairDestination)
        {
            order.SetActive(true);
            eToInteract.SetActive(true);
        }

        if(_onPlace == false)
        OnMyWay(_choosenChairDestination);
    }

    void OnMyWay(Vector3 _choosenChair)
    {
        if(_aCheck == false)
        transform.position = Vector3.MoveTowards(transform.position, VectorA.transform.position, step);
        if (choosenChair > 11 && _aCheck == true)
        {
            _aCheck = true;
            if(_bCheck == false)
            transform.position = Vector3.MoveTowards(transform.position, VectorB.transform.position, step);
            if (_bCheck == true)
            {
                _bCheck = true;
                if(_cCheck == false)
                transform.position = Vector3.MoveTowards(transform.position, VectorC.transform.position, step);
                if (choosenChair > 15 && _cCheck == true)
                {
                    _cCheck = true;
                    if(_dCheck == false)
                    transform.position = Vector3.MoveTowards(transform.position, VectorD.transform.position, step);
                    if (choosenChair > 21 && _dCheck == true)
                    {
                        _dCheck = true;
                        if(_eCheck == false)
                        transform.position = Vector3.MoveTowards(transform.position, VectorE.transform.position, step);
                        if (_eCheck == true)
                        {
                            _eCheck = true;
                            if(choosenChair >= 22 && choosenChair <= 23)
                                {
                                    transform.position = Vector3.MoveTowards(transform.position, VectorE1.transform.position, step);
                                    if(Vector3.Distance(transform.position, VectorE1.transform.position) < 0.01f)
                                    {
                                        _onPlace = true;
                                        transform.position = _choosenChairDestination;
                                    }
                                }
                            if(choosenChair >=24 && choosenChair <= 25)
                                {
                                    transform.position = Vector3.MoveTowards(transform.position, VectorE2.transform.position, step);
                                    if(Vector3.Distance(transform.position, VectorE2.transform.position) < 0.01f)
                                    {
                                        _onPlace = true;
                                        transform.position = _choosenChairDestination;
                                    }
                                }
                            if(choosenChair >=26 && choosenChair <= 27)
                                {
                                    transform.position = Vector3.MoveTowards(transform.position, VectorE3.transform.position, step);
                                    if(Vector3.Distance(transform.position, VectorE3.transform.position) < 0.01f)
                                    {
                                        _onPlace = true;
                                        transform.position = _choosenChairDestination;
                                    }
                                }
                            if(choosenChair >=28 && choosenChair <= 29)
                                {
                                    transform.position = Vector3.MoveTowards(transform.position, VectorE4.transform.position, step);
                                    if(Vector3.Distance(transform.position, VectorE4.transform.position) < 0.01f)
                                    {
                                        _onPlace = true;
                                        transform.position = _choosenChairDestination;
                                    }
                                }
                            return;
                        }
                        else
                        {
                            if (Vector3.Distance(transform.position, VectorE.transform.position) < 0.01f || _eCheck == true)
                            {  
                                _eCheck = true;
                            }
                        }
                    }
                    else
                    {
                        if (Vector3.Distance(transform.position, VectorD.transform.position) < 0.01f || _dCheck == true)
                        {                                
                            _dCheck = true;
                            if(choosenChair >= 16 && choosenChair <= 17)
                            {
                                transform.position = Vector3.MoveTowards(transform.position, VectorD1.transform.position, step);
                                if(Vector3.Distance(transform.position, VectorD1.transform.position) < 0.01f)
                                {
                                    _onPlace = true;
                                    transform.position = _choosenChairDestination;
                                }
                            }
                            if(choosenChair >=18 && choosenChair <= 19)
                            {
                                transform.position = Vector3.MoveTowards(transform.position, VectorD2.transform.position, step);
                                if(Vector3.Distance(transform.position, VectorD2.transform.position) < 0.01f)
                                {
                                        _onPlace = true;
                                        transform.position = _choosenChairDestination;
                                }
                            }
                            if(choosenChair >=20 && choosenChair <= 21)
                            {
                                transform.position = Vector3.MoveTowards(transform.position, VectorD3.transform.position, step);
                                if(Vector3.Distance(transform.position, VectorD3.transform.position) < 0.01f)
                                {
                                    _onPlace = true;
                                    transform.position = _choosenChairDestination;
                                }
                            }
                        }
                        return;
                    }
                }
                else
                {
                    if (Vector3.Distance(transform.position, VectorC.transform.position) < 0.01f || _cCheck == true)
                    {
                        _cCheck = true;
                        if(choosenChair >=12 && choosenChair <= 15)
                        {
                            transform.position = Vector3.MoveTowards(transform.position, VectorC.transform.position, step);
                            if(Vector3.Distance(transform.position, VectorC.transform.position) < 0.01f)
                            {
                                _onPlace = true;
                                transform.position = _choosenChairDestination;
                            }
                        }
                    }
                    return;
                }
            }
            else
            {
                if (Vector3.Distance(transform.position, VectorB.transform.position) < 0.01f || _bCheck == true)
                {
                    _bCheck = true;
                }
                return;
            }
        }
        else
        {
            if(Vector3.Distance(transform.position, VectorA.transform.position) < 0.01f || _aCheck == true)
            {
                _aCheck = true;
                if(choosenChair >= 0 && choosenChair <= 3)
                {
                    transform.position = Vector3.MoveTowards(transform.position, VectorA1.transform.position, step);
                    if(Vector3.Distance(transform.position, VectorA1.transform.position) < 0.01f)
                    {
                        _onPlace = true;
                        transform.position = _choosenChairDestination;
                    }
                }
                if(choosenChair >=4 && choosenChair <= 7)
                {
                    transform.position = Vector3.MoveTowards(transform.position, VectorA2.transform.position, step);
                    if(Vector3.Distance(transform.position, VectorA2.transform.position) < 0.01f)
                    {
                        _onPlace = true;
                        transform.position = _choosenChairDestination;
                    }
                }
                if(choosenChair >=8 && choosenChair <= 11)
                {
                    transform.position = Vector3.MoveTowards(transform.position, VectorA3.transform.position, step);
                    if(Vector3.Distance(transform.position, VectorA3.transform.position) < 0.01f)
                    {
                        _onPlace = true;
                        transform.position = _choosenChairDestination;
                    }
                }
            }
            return;
        }
    }
}
