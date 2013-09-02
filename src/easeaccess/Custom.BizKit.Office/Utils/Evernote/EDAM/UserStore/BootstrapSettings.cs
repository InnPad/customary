/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Custom.Utils.Evernote.EDAM.UserStore
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class BootstrapSettings : TBase
  {
    private string _serviceHost;
    private string _marketingUrl;
    private string _supportUrl;
    private string _accountEmailDomain;
    private bool _enableFacebookSharing;
    private bool _enableGiftSubscriptions;
    private bool _enableSupportTickets;
    private bool _enableSharedNotebooks;
    private bool _enableSingleNoteSharing;
    private bool _enableSponsoredAccounts;
    private bool _enableTwitterSharing;
    private bool _enableLinkedInSharing;
    private bool _enablePublicNotebooks;

    public string ServiceHost
    {
      get
      {
        return _serviceHost;
      }
      set
      {
        __isset.serviceHost = true;
        this._serviceHost = value;
      }
    }

    public string MarketingUrl
    {
      get
      {
        return _marketingUrl;
      }
      set
      {
        __isset.marketingUrl = true;
        this._marketingUrl = value;
      }
    }

    public string SupportUrl
    {
      get
      {
        return _supportUrl;
      }
      set
      {
        __isset.supportUrl = true;
        this._supportUrl = value;
      }
    }

    public string AccountEmailDomain
    {
      get
      {
        return _accountEmailDomain;
      }
      set
      {
        __isset.accountEmailDomain = true;
        this._accountEmailDomain = value;
      }
    }

    public bool EnableFacebookSharing
    {
      get
      {
        return _enableFacebookSharing;
      }
      set
      {
        __isset.enableFacebookSharing = true;
        this._enableFacebookSharing = value;
      }
    }

    public bool EnableGiftSubscriptions
    {
      get
      {
        return _enableGiftSubscriptions;
      }
      set
      {
        __isset.enableGiftSubscriptions = true;
        this._enableGiftSubscriptions = value;
      }
    }

    public bool EnableSupportTickets
    {
      get
      {
        return _enableSupportTickets;
      }
      set
      {
        __isset.enableSupportTickets = true;
        this._enableSupportTickets = value;
      }
    }

    public bool EnableSharedNotebooks
    {
      get
      {
        return _enableSharedNotebooks;
      }
      set
      {
        __isset.enableSharedNotebooks = true;
        this._enableSharedNotebooks = value;
      }
    }

    public bool EnableSingleNoteSharing
    {
      get
      {
        return _enableSingleNoteSharing;
      }
      set
      {
        __isset.enableSingleNoteSharing = true;
        this._enableSingleNoteSharing = value;
      }
    }

    public bool EnableSponsoredAccounts
    {
      get
      {
        return _enableSponsoredAccounts;
      }
      set
      {
        __isset.enableSponsoredAccounts = true;
        this._enableSponsoredAccounts = value;
      }
    }

    public bool EnableTwitterSharing
    {
      get
      {
        return _enableTwitterSharing;
      }
      set
      {
        __isset.enableTwitterSharing = true;
        this._enableTwitterSharing = value;
      }
    }

    public bool EnableLinkedInSharing
    {
      get
      {
        return _enableLinkedInSharing;
      }
      set
      {
        __isset.enableLinkedInSharing = true;
        this._enableLinkedInSharing = value;
      }
    }

    public bool EnablePublicNotebooks
    {
      get
      {
        return _enablePublicNotebooks;
      }
      set
      {
        __isset.enablePublicNotebooks = true;
        this._enablePublicNotebooks = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool serviceHost;
      public bool marketingUrl;
      public bool supportUrl;
      public bool accountEmailDomain;
      public bool enableFacebookSharing;
      public bool enableGiftSubscriptions;
      public bool enableSupportTickets;
      public bool enableSharedNotebooks;
      public bool enableSingleNoteSharing;
      public bool enableSponsoredAccounts;
      public bool enableTwitterSharing;
      public bool enableLinkedInSharing;
      public bool enablePublicNotebooks;
    }

    public BootstrapSettings() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              ServiceHost = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              MarketingUrl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              SupportUrl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              AccountEmailDomain = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              EnableFacebookSharing = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              EnableGiftSubscriptions = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Bool) {
              EnableSupportTickets = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Bool) {
              EnableSharedNotebooks = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Bool) {
              EnableSingleNoteSharing = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Bool) {
              EnableSponsoredAccounts = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Bool) {
              EnableTwitterSharing = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Bool) {
              EnableLinkedInSharing = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.Bool) {
              EnablePublicNotebooks = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("BootstrapSettings");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ServiceHost != null && __isset.serviceHost) {
        field.Name = "serviceHost";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ServiceHost);
        oprot.WriteFieldEnd();
      }
      if (MarketingUrl != null && __isset.marketingUrl) {
        field.Name = "marketingUrl";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(MarketingUrl);
        oprot.WriteFieldEnd();
      }
      if (SupportUrl != null && __isset.supportUrl) {
        field.Name = "supportUrl";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SupportUrl);
        oprot.WriteFieldEnd();
      }
      if (AccountEmailDomain != null && __isset.accountEmailDomain) {
        field.Name = "accountEmailDomain";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AccountEmailDomain);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableFacebookSharing) {
        field.Name = "enableFacebookSharing";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableFacebookSharing);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableGiftSubscriptions) {
        field.Name = "enableGiftSubscriptions";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableGiftSubscriptions);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableSupportTickets) {
        field.Name = "enableSupportTickets";
        field.Type = TType.Bool;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableSupportTickets);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableSharedNotebooks) {
        field.Name = "enableSharedNotebooks";
        field.Type = TType.Bool;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableSharedNotebooks);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableSingleNoteSharing) {
        field.Name = "enableSingleNoteSharing";
        field.Type = TType.Bool;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableSingleNoteSharing);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableSponsoredAccounts) {
        field.Name = "enableSponsoredAccounts";
        field.Type = TType.Bool;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableSponsoredAccounts);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableTwitterSharing) {
        field.Name = "enableTwitterSharing";
        field.Type = TType.Bool;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableTwitterSharing);
        oprot.WriteFieldEnd();
      }
      if (__isset.enableLinkedInSharing) {
        field.Name = "enableLinkedInSharing";
        field.Type = TType.Bool;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnableLinkedInSharing);
        oprot.WriteFieldEnd();
      }
      if (__isset.enablePublicNotebooks) {
        field.Name = "enablePublicNotebooks";
        field.Type = TType.Bool;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(EnablePublicNotebooks);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("BootstrapSettings(");
      sb.Append("ServiceHost: ");
      sb.Append(ServiceHost);
      sb.Append(",MarketingUrl: ");
      sb.Append(MarketingUrl);
      sb.Append(",SupportUrl: ");
      sb.Append(SupportUrl);
      sb.Append(",AccountEmailDomain: ");
      sb.Append(AccountEmailDomain);
      sb.Append(",EnableFacebookSharing: ");
      sb.Append(EnableFacebookSharing);
      sb.Append(",EnableGiftSubscriptions: ");
      sb.Append(EnableGiftSubscriptions);
      sb.Append(",EnableSupportTickets: ");
      sb.Append(EnableSupportTickets);
      sb.Append(",EnableSharedNotebooks: ");
      sb.Append(EnableSharedNotebooks);
      sb.Append(",EnableSingleNoteSharing: ");
      sb.Append(EnableSingleNoteSharing);
      sb.Append(",EnableSponsoredAccounts: ");
      sb.Append(EnableSponsoredAccounts);
      sb.Append(",EnableTwitterSharing: ");
      sb.Append(EnableTwitterSharing);
      sb.Append(",EnableLinkedInSharing: ");
      sb.Append(EnableLinkedInSharing);
      sb.Append(",EnablePublicNotebooks: ");
      sb.Append(EnablePublicNotebooks);
      sb.Append(")");
      return sb.ToString();
    }

  }

}