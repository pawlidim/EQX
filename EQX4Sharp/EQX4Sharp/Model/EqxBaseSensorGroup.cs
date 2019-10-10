// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.0.0.47. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace EQX4Sharp.Model
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.Diagnostics.DebuggerStepThroughAttribute()]
public partial class EqxBaseSensorGroup
{
    
    #region Private fields
    private List<EqxSensorGroup> _sensorGroup;
    
    private List<EqxSensorAxis> _sensor;
    
    private List<EqxAttachment> _attachment;
    
    private string _remark;
    
    private List<EqxAttribute> _attribute;
    
    private List<System.Xml.XmlElement> _any;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public EqxBaseSensorGroup()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
        this._any = new List<System.Xml.XmlElement>();
        this._attribute = new List<EqxAttribute>();
        this._attachment = new List<EqxAttachment>();
        this._sensor = new List<EqxSensorAxis>();
        this._sensorGroup = new List<EqxSensorGroup>();
    }
    
    public List<EqxSensorGroup> SensorGroup
    {
        get
        {
            return this._sensorGroup;
        }
        set
        {
            this._sensorGroup = value;
        }
    }
    
    public List<EqxSensorAxis> Sensor
    {
        get
        {
            return this._sensor;
        }
        set
        {
            this._sensor = value;
        }
    }
    
    public List<EqxAttachment> Attachment
    {
        get
        {
            return this._attachment;
        }
        set
        {
            this._attachment = value;
        }
    }
    
    public string Remark
    {
        get
        {
            return this._remark;
        }
        set
        {
            this._remark = value;
        }
    }
    
    public List<EqxAttribute> Attribute
    {
        get
        {
            return this._attribute;
        }
        set
        {
            this._attribute = value;
        }
    }
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public List<System.Xml.XmlElement> Any
    {
        get
        {
            return this._any;
        }
        set
        {
            this._any = value;
        }
    }
    
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public List<System.Xml.XmlAttribute> AnyAttr
    {
        get
        {
            return this._anyAttr;
        }
        set
        {
            this._anyAttr = value;
        }
    }
}
}
#pragma warning restore
