﻿//25/09/2013 : <!-- PL_006s - 01/10/2013 - Inclusão de campos de controle Resolução 13: FCI (NT 2013/006) -->
//25/09/2013 : inclusao do tipo item8 em TOrig
//25/09/2013 : inclusao do tipo item91 em TCOrgaoIBGE PL_006s
//27/05/2013 : inclusao campos vTotTrib em M01 e W02
//29/11/2012 : campo tOrig - incluido valores {3,4,5,6,7}


using System.Xml.Serialization;
using NFeDownload.NFe.SchemaXML;

namespace NFeDownload.NFe.SchemaXML200
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("cancNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TCancNFe
    {

        private TCancNFeInfCanc infCancField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TCancNFeInfCanc infCanc
        {
            get
            {
                return this.infCancField;
            }
            set
            {
                this.infCancField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TCancNFeInfCanc
    {

        private TAmb tpAmbField;

        private TCancNFeInfCancXServ xServField;

        private string chNFeField;

        private string nProtField;

        private string xJustField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public TCancNFeInfCancXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {

        private byte[] x509CertificateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {

        private X509DataType x509DataField;

        private string idField;

        /// <remarks/>
        public X509DataType X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {

        private string[] xPathField;

        private TTransformURI algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {

        private TransformType[] transformsField;

        private ReferenceTypeDigestMethod digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {

        private string algorithmField;

        public ReferenceTypeDigestMethod()
        {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;

        private SignedInfoTypeSignatureMethod signatureMethodField;

        private ReferenceType referenceField;

        private string idField;

        /// <remarks/>
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignedInfoTypeSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        public ReferenceType Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {

        private string algorithmField;

        public SignedInfoTypeCanonicalizationMethod()
        {
            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {

        private string algorithmField;

        public SignedInfoTypeSignatureMethod()
        {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private string idField;

        /// <remarks/>
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("evento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEvento
    {

        private TEventoInfEvento infEventoField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TEventoInfEvento infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEvento
    {

        private TCOrgaoIBGE cOrgaoField;

        private TAmb tpAmbField;

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string chNFeField;

        private string dhEventoField;

        private TEventoInfEventoTpEvento tpEventoField;

        private string nSeqEventoField;

        private TEventoInfEventoVerEvento verEventoField;

        //deverá ser um choice entre cancelamento e carta de correção
        private TEventoInfEventoDetEvento detEventoField;
        //private object detEventoField;

        private string idField;

        /// <remarks/>
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        /// <remarks/>
        public TEventoInfEventoTpEvento tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        /// <remarks/>
        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        /// <remarks/>
        public TEventoInfEventoVerEvento verEvento
        {
            get
            {
                return this.verEventoField;
            }
            set
            {
                this.verEventoField = value;
            }
        }
        //[System.Xml.Serialization.XmlElementAttribute("detEvento", typeof(TEventoInfEventoDetEventoCartaCorrecao))]
        //[System.Xml.Serialization.XmlElementAttribute("detEvento", typeof(TEventoInfEventoDetEventoCancelamento))]
        //[System.Xml.Serialization.XmlElement("")]
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public object detEvento
        /// <remarks/>
        public TEventoInfEventoDetEvento detEvento
        {
            get
            {
                return this.detEventoField;
            }
            set
            {
                this.detEventoField = value;
            }
        }



        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("ConsCad", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsCad
    {

        private TConsCadInfCons infConsField;

        private string versaoField;

        /// <remarks/>
        public TConsCadInfCons infCons
        {
            get
            {
                return this.infConsField;
            }
            set
            {
                this.infConsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TConsCadInfCons
    {

        private TConsCadInfConsXServ xServField;

        private TUfCons ufField;

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        public TConsCadInfConsXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        /// <remarks/>
        public TUfCons UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("IE", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TConsCadInfConsXServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CONS-CAD")]
        CONSCAD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUfCons
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,

        /// <remarks/>
        SU,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        IE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsReciNFe
    {

        private TAmb tpAmbField;

        private string nRecField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string nRec
        {
            get
            {
                return this.nRecField;
            }
            set
            {
                this.nRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsSitNFe
    {

        private TAmb tpAmbField;

        private TConsSitNFeXServ xServField;

        private string chNFeField;

        private TVerConsSitNFe versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public TConsSitNFeXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerConsSitNFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsStatServ
    {

        private TAmb tpAmbField;

        private TCodUfIBGE cUFField;

        private TConsStatServXServ xServField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public TConsStatServXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("enviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEnviNFe
    {

        private string idLoteField;

        private TNFe[] nFeField;

        private string versaoField;

        /// <remarks/>
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NFe")]
        public TNFe[] NFe
        {
            get
            {
                return this.nFeField;
            }
            set
            {
                this.nFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TNFe
    {

        private TNFeInfNFe infNFeField;

        private SignatureType signatureField;

        /// <remarks/>
        public TNFeInfNFe infNFe
        {
            get
            {
                return this.infNFeField;
            }
            set
            {
                this.infNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFe
    {

        private TNFeInfNFeIde ideField;

        private TNFeInfNFeEmit emitField;

        private TNFeInfNFeAvulsa avulsaField;

        private TNFeInfNFeDest destField;

        private TLocal retiradaField;

        private TLocal entregaField;

        private TNFeInfNFeDet[] detField;

        private TNFeInfNFeTotal totalField;

        private TNFeInfNFeTransp transpField;

        private TNFeInfNFeCobr cobrField;

        private TNFeInfNFeInfAdic infAdicField;

        private TNFeInfNFeExporta exportaField;

        private TNFeInfNFeCompra compraField;

        private TNFeInfNFeCana canaField;

        private string versaoField;

        private string idField;

        /// <remarks/>
        public TNFeInfNFeIde ide
        {
            get
            {
                return this.ideField;
            }
            set
            {
                this.ideField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeEmit emit
        {
            get
            {
                return this.emitField;
            }
            set
            {
                this.emitField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeAvulsa avulsa
        {
            get
            {
                return this.avulsaField;
            }
            set
            {
                this.avulsaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDest dest
        {
            get
            {
                return this.destField;
            }
            set
            {
                this.destField = value;
            }
        }

        /// <remarks/>
        public TLocal retirada
        {
            get
            {
                return this.retiradaField;
            }
            set
            {
                this.retiradaField = value;
            }
        }

        /// <remarks/>
        public TLocal entrega
        {
            get
            {
                return this.entregaField;
            }
            set
            {
                this.entregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("det")]
        public TNFeInfNFeDet[] det
        {
            get
            {
                return this.detField;
            }
            set
            {
                this.detField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTotal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTransp transp
        {
            get
            {
                return this.transpField;
            }
            set
            {
                this.transpField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeCobr cobr
        {
            get
            {
                return this.cobrField;
            }
            set
            {
                this.cobrField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeInfAdic infAdic
        {
            get
            {
                return this.infAdicField;
            }
            set
            {
                this.infAdicField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeExporta exporta
        {
            get
            {
                return this.exportaField;
            }
            set
            {
                this.exportaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeCompra compra
        {
            get
            {
                return this.compraField;
            }
            set
            {
                this.compraField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeCana cana
        {
            get
            {
                return this.canaField;
            }
            set
            {
                this.canaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIde : NFeDownload.NFe.SchemaXML.ITNFeInfNFeIde
    {

        private TCodUfIBGE cUFField;

        private string cNFField;

        private string natOpField;

        private TNFeInfNFeIdeIndPag indPagField;

        private TMod modField;

        private string serieField;

        private string nNFField;

        private string dEmiField;

        private string dSaiEntField;

        private string hSaiEntField;

        private TNFeInfNFeIdeTpNF tpNFField;

        private string cMunFGField;

        private TNFeInfNFeIdeNFref[] nFrefField;

        private TNFeInfNFeIdeTpImp tpImpField;

        private TNFeInfNFeIdeTpEmis tpEmisField;

        private string cDVField;

        private TAmb tpAmbField;

        private TFinNFe finNFeField;

        private TProcEmi procEmiField;

        private string verProcField;

        private string dhContField;

        private string xJustField;

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string cNF
        {
            get
            {
                return this.cNFField;
            }
            set
            {
                this.cNFField = value;
            }
        }

        /// <remarks/>
        public string natOp
        {
            get
            {
                return this.natOpField;
            }
            set
            {
                this.natOpField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeIndPag indPag
        {
            get
            {
                return this.indPagField;
            }
            set
            {
                this.indPagField = value;
            }
        }

        /// <remarks/>
        public TMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

        /// <remarks/>
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        /// <remarks/>
        public string dSaiEnt
        {
            get
            {
                return this.dSaiEntField;
            }
            set
            {
                this.dSaiEntField = value;
            }
        }

        /// <remarks/>
        public string hSaiEnt
        {
            get
            {
                return this.hSaiEntField;
            }
            set
            {
                this.hSaiEntField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeTpNF tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        /// <remarks/>
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NFref")]
        public TNFeInfNFeIdeNFref[] NFref
        {
            get
            {
                return this.nFrefField;
            }
            set
            {
                this.nFrefField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeTpImp tpImp
        {
            get
            {
                return this.tpImpField;
            }
            set
            {
                this.tpImpField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeTpEmis tpEmis
        {
            get
            {
                return this.tpEmisField;
            }
            set
            {
                this.tpEmisField = value;
            }
        }

        /// <remarks/>
        public string cDV
        {
            get
            {
                return this.cDVField;
            }
            set
            {
                this.cDVField = value;
            }
        }

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public TFinNFe finNFe
        {
            get
            {
                return this.finNFeField;
            }
            set
            {
                this.finNFeField = value;
            }
        }

        /// <remarks/>
        public TProcEmi procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        /// <remarks/>
        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }

        /// <remarks/>
        public string dhCont
        {
            get
            {
                return this.dhContField;
            }
            set
            {
                this.dhContField = value;
            }
        }

        /// <remarks/>
        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPag
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFref
    {

        private object itemField;

        private ItemChoiceType3 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("refCTe", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("refECF", typeof(TNFeInfNFeIdeNFrefRefECF))]
        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TNFeInfNFeIdeNFrefRefNF))]
        [System.Xml.Serialization.XmlElementAttribute("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP))]
        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefECF
    {

        private TNFeInfNFeIdeNFrefRefECFMod modField;

        private string nECFField;

        private string nCOOField;

        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefECFMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public string nECF
        {
            get
            {
                return this.nECFField;
            }
            set
            {
                this.nECFField = value;
            }
        }

        /// <remarks/>
        public string nCOO
        {
            get
            {
                return this.nCOOField;
            }
            set
            {
                this.nCOOField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefECFMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2B")]
        Item2B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2C")]
        Item2C,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2D")]
        Item2D,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNF
    {

        private TCodUfIBGE cUFField;

        private string aAMMField;

        private string cNPJField;

        private TNFeInfNFeIdeNFrefRefNFMod modField;

        private string serieField;

        private string nNFField;

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string AAMM
        {
            get
            {
                return this.aAMMField;
            }
            set
            {
                this.aAMMField = value;
            }
        }

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefNFMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNFP
    {

        private TCodUfIBGE cUFField;

        private string aAMMField;

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string ieField;

        private TNFeInfNFeIdeNFrefRefNFPMod modField;

        private string serieField;

        private string nNFField;

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string AAMM
        {
            get
            {
                return this.aAMMField;
            }
            set
            {
                this.aAMMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefNFPMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFPMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

        /// <remarks/>
        refCTe,

        /// <remarks/>
        refECF,

        /// <remarks/>
        refNF,

        /// <remarks/>
        refNFP,

        /// <remarks/>
        refNFe,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpImp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TFinNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TProcEmi
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeEmit
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string xNomeField;

        private string xFantField;

        private TEnderEmi enderEmitField;

        private string ieField;

        private string iESTField;

        private string imField;

        private string cNAEField;

        private TNFeInfNFeEmitCRT cRTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public string xFant
        {
            get
            {
                return this.xFantField;
            }
            set
            {
                this.xFantField = value;
            }
        }

        /// <remarks/>
        public TEnderEmi enderEmit
        {
            get
            {
                return this.enderEmitField;
            }
            set
            {
                this.enderEmitField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public string IEST
        {
            get
            {
                return this.iESTField;
            }
            set
            {
                this.iESTField = value;
            }
        }

        /// <remarks/>
        public string IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        /// <remarks/>
        public string CNAE
        {
            get
            {
                return this.cNAEField;
            }
            set
            {
                this.cNAEField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeEmitCRT CRT
        {
            get
            {
                return this.cRTField;
            }
            set
            {
                this.cRTField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEnderEmi
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUfEmi ufField;

        private string cEPField;

        private TEnderEmiCPais cPaisField;

        private bool cPaisFieldSpecified;

        private TEnderEmiXPais xPaisField;

        private bool xPaisFieldSpecified;

        private string foneField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public TUfEmi UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        /// <remarks/>
        public TEnderEmiCPais cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cPaisSpecified
        {
            get
            {
                return this.cPaisFieldSpecified;
            }
            set
            {
                this.cPaisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TEnderEmiXPais xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xPaisSpecified
        {
            get
            {
                return this.xPaisFieldSpecified;
            }
            set
            {
                this.xPaisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiCPais
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1058")]
        Item1058,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiXPais
    {

        /// <remarks/>
        Brasil,

        /// <remarks/>
        BRASIL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeEmitCRT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAvulsa
    {

        private string cNPJField;

        private string xOrgaoField;

        private string matrField;

        private string xAgenteField;

        private string foneField;

        private TUfEmi ufField;

        private string nDARField;

        private string dEmiField;

        private string vDARField;

        private string repEmiField;

        private string dPagField;

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string xOrgao
        {
            get
            {
                return this.xOrgaoField;
            }
            set
            {
                this.xOrgaoField = value;
            }
        }

        /// <remarks/>
        public string matr
        {
            get
            {
                return this.matrField;
            }
            set
            {
                this.matrField = value;
            }
        }

        /// <remarks/>
        public string xAgente
        {
            get
            {
                return this.xAgenteField;
            }
            set
            {
                this.xAgenteField = value;
            }
        }

        /// <remarks/>
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

        /// <remarks/>
        public TUfEmi UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public string nDAR
        {
            get
            {
                return this.nDARField;
            }
            set
            {
                this.nDARField = value;
            }
        }

        /// <remarks/>
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        /// <remarks/>
        public string vDAR
        {
            get
            {
                return this.vDARField;
            }
            set
            {
                this.vDARField = value;
            }
        }

        /// <remarks/>
        public string repEmi
        {
            get
            {
                return this.repEmiField;
            }
            set
            {
                this.repEmiField = value;
            }
        }

        /// <remarks/>
        public string dPag
        {
            get
            {
                return this.dPagField;
            }
            set
            {
                this.dPagField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDest : NFeDownload.NFe.SchemaXML.ITNFeInfNFeDest
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string xNomeField;

        private TEndereco enderDestField;

        private string ieField;

        private string iSUFField;

        private string emailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public TEndereco enderDest
        {
            get
            {
                return this.enderDestField;
            }
            set
            {
                this.enderDestField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public string ISUF
        {
            get
            {
                return this.iSUFField;
            }
            set
            {
                this.iSUFField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEndereco
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUf ufField;

        private string cEPField;

        private string cPaisField;

        private string xPaisField;

        private string foneField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        /// <remarks/>
        public string xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TLocal
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUf ufField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDet
    {

        private TNFeInfNFeDetProd prodField;

        private TNFeInfNFeDetImposto impostoField;

        private string infAdProdField;

        private string nItemField;

        /// <remarks/>
        public TNFeInfNFeDetProd prod
        {
            get
            {
                return this.prodField;
            }
            set
            {
                this.prodField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImposto imposto
        {
            get
            {
                return this.impostoField;
            }
            set
            {
                this.impostoField = value;
            }
        }

        /// <remarks/>
        public string infAdProd
        {
            get
            {
                return this.infAdProdField;
            }
            set
            {
                //remoçao /n para NEGESYS
                //rever aplicação
                string infAdProdTemp = value.Replace("\n", "");

                this.infAdProdField = infAdProdTemp;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nItem
        {
            get
            {
                return this.nItemField;
            }
            set
            {
                this.nItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProd
    {

        private string cProdField;

        private string cEANField;

        private string xProdField;

        private string nCMField;

        private string eXTIPIField;

        private TCfop cFOPField;

        private string uComField;

        private string qComField;

        private string vUnComField;

        private string vProdField;

        private string cEANTribField;

        private string uTribField;

        private string qTribField;

        private string vUnTribField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vOutroField;

        private TNFeInfNFeDetProdIndTot indTotField;

        private TNFeInfNFeDetProdDI[] diField;

        private string xPedField;

        private string nItemPedField;

        private string nFCIField;

        private object[] itemsField;

        /// <remarks/>
        public string cProd
        {
            get
            {
                return this.cProdField;
            }
            set
            {
                this.cProdField = value;
            }
        }

        /// <remarks/>
        public string cEAN
        {
            get
            {
                return this.cEANField;
            }
            set
            {
                this.cEANField = value;
            }
        }

        /// <remarks/>
        public string xProd
        {
            get
            {
                return this.xProdField;
            }
            set
            {
                this.xProdField = value;
            }
        }

        /// <remarks/>
        public string NCM
        {
            get
            {
                return this.nCMField;
            }
            set
            {
                this.nCMField = value;
            }
        }

        /// <remarks/>
        public string EXTIPI
        {
            get
            {
                return this.eXTIPIField;
            }
            set
            {
                this.eXTIPIField = value;
            }
        }

        /// <remarks/>
        public TCfop CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        /// <remarks/>
        public string uCom
        {
            get
            {
                return this.uComField;
            }
            set
            {
                this.uComField = value;
            }
        }

        /// <remarks/>
        public string qCom
        {
            get
            {
                return this.qComField;
            }
            set
            {
                this.qComField = value;
            }
        }

        /// <remarks/>
        public string vUnCom
        {
            get
            {
                return this.vUnComField;
            }
            set
            {
                this.vUnComField = value;
            }
        }

        /// <remarks/>
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public string cEANTrib
        {
            get
            {
                return this.cEANTribField;
            }
            set
            {
                this.cEANTribField = value;
            }
        }

        /// <remarks/>
        public string uTrib
        {
            get
            {
                return this.uTribField;
            }
            set
            {
                this.uTribField = value;
            }
        }

        /// <remarks/>
        public string qTrib
        {
            get
            {
                return this.qTribField;
            }
            set
            {
                this.qTribField = value;
            }
        }

        /// <remarks/>
        public string vUnTrib
        {
            get
            {
                return this.vUnTribField;
            }
            set
            {
                this.vUnTribField = value;
            }
        }

        /// <remarks/>
        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        /// <remarks/>
        public string vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        /// <remarks/>
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        /// <remarks/>
        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdIndTot indTot
        {
            get
            {
                return this.indTotField;
            }
            set
            {
                this.indTotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DI")]
        public TNFeInfNFeDetProdDI[] DI
        {
            get
            {
                return this.diField;
            }
            set
            {
                this.diField = value;
            }
        }

        /// <remarks/>
        public string xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }

        /// <remarks/>
        public string nItemPed
        {
            get
            {
                return this.nItemPedField;
            }
            set
            {
                this.nItemPedField = value;
            }
        }

        /// <remarks/>
        public string nFCI
        {
            get
            {
                return this.nFCIField;
            }
            set
            {
                this.nFCIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
        [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
        [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
        [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCfop
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1101")]
        Item1101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1102")]
        Item1102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1111")]
        Item1111,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1113")]
        Item1113,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1116")]
        Item1116,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1117")]
        Item1117,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1118")]
        Item1118,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1120")]
        Item1120,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1121")]
        Item1121,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1122")]
        Item1122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1124")]
        Item1124,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1125")]
        Item1125,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1126")]
        Item1126,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1128")]
        Item1128,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1151")]
        Item1151,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1152")]
        Item1152,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1153")]
        Item1153,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1154")]
        Item1154,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1201")]
        Item1201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1202")]
        Item1202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1203")]
        Item1203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1204")]
        Item1204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1205")]
        Item1205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1206")]
        Item1206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1207")]
        Item1207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1208")]
        Item1208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1209")]
        Item1209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1251")]
        Item1251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1252")]
        Item1252,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1253")]
        Item1253,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1254")]
        Item1254,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1255")]
        Item1255,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1256")]
        Item1256,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1257")]
        Item1257,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1301")]
        Item1301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1302")]
        Item1302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1303")]
        Item1303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1304")]
        Item1304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1305")]
        Item1305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1306")]
        Item1306,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1351")]
        Item1351,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1352")]
        Item1352,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1353")]
        Item1353,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1354")]
        Item1354,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1355")]
        Item1355,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1356")]
        Item1356,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1360")]
        Item1360,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1401")]
        Item1401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1403")]
        Item1403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1406")]
        Item1406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1407")]
        Item1407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1408")]
        Item1408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1409")]
        Item1409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1410")]
        Item1410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1411")]
        Item1411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1414")]
        Item1414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1415")]
        Item1415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1451")]
        Item1451,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1452")]
        Item1452,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1501")]
        Item1501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1503")]
        Item1503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1504")]
        Item1504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1505")]
        Item1505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1506")]
        Item1506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1551")]
        Item1551,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1552")]
        Item1552,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1553")]
        Item1553,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1554")]
        Item1554,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1555")]
        Item1555,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1556")]
        Item1556,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1557")]
        Item1557,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1601")]
        Item1601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1602")]
        Item1602,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1603")]
        Item1603,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1604")]
        Item1604,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1605")]
        Item1605,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1651")]
        Item1651,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1652")]
        Item1652,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1653")]
        Item1653,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1658")]
        Item1658,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1659")]
        Item1659,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1660")]
        Item1660,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1661")]
        Item1661,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1662")]
        Item1662,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1663")]
        Item1663,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1664")]
        Item1664,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1901")]
        Item1901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1902")]
        Item1902,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1903")]
        Item1903,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1904")]
        Item1904,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1905")]
        Item1905,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1906")]
        Item1906,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1907")]
        Item1907,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1908")]
        Item1908,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1909")]
        Item1909,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1910")]
        Item1910,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1911")]
        Item1911,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1912")]
        Item1912,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1913")]
        Item1913,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1914")]
        Item1914,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1915")]
        Item1915,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1916")]
        Item1916,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1917")]
        Item1917,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1918")]
        Item1918,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1919")]
        Item1919,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1920")]
        Item1920,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1921")]
        Item1921,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1922")]
        Item1922,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1923")]
        Item1923,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1924")]
        Item1924,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1925")]
        Item1925,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1926")]
        Item1926,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1931")]
        Item1931,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1932")]
        Item1932,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1933")]
        Item1933,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1934")]
        Item1934,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1949")]
        Item1949,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2101")]
        Item2101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2102")]
        Item2102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2111")]
        Item2111,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2113")]
        Item2113,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2116")]
        Item2116,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2117")]
        Item2117,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2118")]
        Item2118,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2120")]
        Item2120,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2121")]
        Item2121,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2122")]
        Item2122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2124")]
        Item2124,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2125")]
        Item2125,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2126")]
        Item2126,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2128")]
        Item2128,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2151")]
        Item2151,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2152")]
        Item2152,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2153")]
        Item2153,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2154")]
        Item2154,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2201")]
        Item2201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2202")]
        Item2202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2203")]
        Item2203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2204")]
        Item2204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2205")]
        Item2205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2206")]
        Item2206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2207")]
        Item2207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2208")]
        Item2208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2209")]
        Item2209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2251")]
        Item2251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2252")]
        Item2252,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2253")]
        Item2253,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2254")]
        Item2254,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2255")]
        Item2255,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2256")]
        Item2256,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2257")]
        Item2257,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2301")]
        Item2301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2302")]
        Item2302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2303")]
        Item2303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2304")]
        Item2304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2305")]
        Item2305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2306")]
        Item2306,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2351")]
        Item2351,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2352")]
        Item2352,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2353")]
        Item2353,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2354")]
        Item2354,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2355")]
        Item2355,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2356")]
        Item2356,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2401")]
        Item2401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2403")]
        Item2403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2406")]
        Item2406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2407")]
        Item2407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2408")]
        Item2408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2409")]
        Item2409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2410")]
        Item2410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2411")]
        Item2411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2414")]
        Item2414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2415")]
        Item2415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2501")]
        Item2501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2503")]
        Item2503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2504")]
        Item2504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2505")]
        Item2505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2506")]
        Item2506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2551")]
        Item2551,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2552")]
        Item2552,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2553")]
        Item2553,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2554")]
        Item2554,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2555")]
        Item2555,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2556")]
        Item2556,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2557")]
        Item2557,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2603")]
        Item2603,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2651")]
        Item2651,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2652")]
        Item2652,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2653")]
        Item2653,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2658")]
        Item2658,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2659")]
        Item2659,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2660")]
        Item2660,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2661")]
        Item2661,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2662")]
        Item2662,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2663")]
        Item2663,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2664")]
        Item2664,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2901")]
        Item2901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2902")]
        Item2902,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2903")]
        Item2903,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2904")]
        Item2904,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2905")]
        Item2905,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2906")]
        Item2906,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2907")]
        Item2907,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2908")]
        Item2908,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2909")]
        Item2909,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2910")]
        Item2910,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2911")]
        Item2911,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2912")]
        Item2912,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2913")]
        Item2913,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2914")]
        Item2914,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2915")]
        Item2915,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2916")]
        Item2916,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2917")]
        Item2917,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2918")]
        Item2918,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2919")]
        Item2919,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2920")]
        Item2920,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2921")]
        Item2921,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2922")]
        Item2922,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2923")]
        Item2923,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2924")]
        Item2924,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2925")]
        Item2925,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2931")]
        Item2931,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2932")]
        Item2932,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2933")]
        Item2933,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2934")]
        Item2934,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2949")]
        Item2949,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3101")]
        Item3101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3102")]
        Item3102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3126")]
        Item3126,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3127")]
        Item3127,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3128")]
        Item3128,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3201")]
        Item3201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3202")]
        Item3202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3205")]
        Item3205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3206")]
        Item3206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3207")]
        Item3207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3211")]
        Item3211,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3251")]
        Item3251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3301")]
        Item3301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3351")]
        Item3351,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3352")]
        Item3352,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3353")]
        Item3353,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3354")]
        Item3354,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3355")]
        Item3355,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3356")]
        Item3356,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3503")]
        Item3503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3551")]
        Item3551,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3553")]
        Item3553,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3556")]
        Item3556,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3651")]
        Item3651,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3652")]
        Item3652,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3653")]
        Item3653,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3930")]
        Item3930,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3949")]
        Item3949,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5101")]
        Item5101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5102")]
        Item5102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5103")]
        Item5103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5104")]
        Item5104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5105")]
        Item5105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5106")]
        Item5106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5109")]
        Item5109,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5110")]
        Item5110,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5111")]
        Item5111,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5112")]
        Item5112,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5113")]
        Item5113,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5114")]
        Item5114,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5115")]
        Item5115,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5116")]
        Item5116,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5117")]
        Item5117,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5118")]
        Item5118,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5119")]
        Item5119,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5120")]
        Item5120,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5122")]
        Item5122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5123")]
        Item5123,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5124")]
        Item5124,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5125")]
        Item5125,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5151")]
        Item5151,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5152")]
        Item5152,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5153")]
        Item5153,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5155")]
        Item5155,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5156")]
        Item5156,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5201")]
        Item5201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5202")]
        Item5202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5205")]
        Item5205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5206")]
        Item5206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5207")]
        Item5207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5208")]
        Item5208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5209")]
        Item5209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5210")]
        Item5210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5251")]
        Item5251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5252")]
        Item5252,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5253")]
        Item5253,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5254")]
        Item5254,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5255")]
        Item5255,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5256")]
        Item5256,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5257")]
        Item5257,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5258")]
        Item5258,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5401")]
        Item5401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5402")]
        Item5402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5403")]
        Item5403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5405")]
        Item5405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5408")]
        Item5408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5409")]
        Item5409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5410")]
        Item5410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5411")]
        Item5411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5412")]
        Item5412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5413")]
        Item5413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5414")]
        Item5414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5415")]
        Item5415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5451")]
        Item5451,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5501")]
        Item5501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5502")]
        Item5502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5503")]
        Item5503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5504")]
        Item5504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5505")]
        Item5505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5551")]
        Item5551,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5552")]
        Item5552,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5553")]
        Item5553,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5554")]
        Item5554,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5555")]
        Item5555,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5556")]
        Item5556,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5557")]
        Item5557,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5601")]
        Item5601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5602")]
        Item5602,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5603")]
        Item5603,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5605")]
        Item5605,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5606")]
        Item5606,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5651")]
        Item5651,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5652")]
        Item5652,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5653")]
        Item5653,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5654")]
        Item5654,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5655")]
        Item5655,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5656")]
        Item5656,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5657")]
        Item5657,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5658")]
        Item5658,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5659")]
        Item5659,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5660")]
        Item5660,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5661")]
        Item5661,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5662")]
        Item5662,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5663")]
        Item5663,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5664")]
        Item5664,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5665")]
        Item5665,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5666")]
        Item5666,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5667")]
        Item5667,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5901")]
        Item5901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5902")]
        Item5902,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5903")]
        Item5903,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5904")]
        Item5904,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5905")]
        Item5905,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5906")]
        Item5906,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5907")]
        Item5907,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5908")]
        Item5908,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5909")]
        Item5909,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5910")]
        Item5910,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5911")]
        Item5911,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5912")]
        Item5912,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5913")]
        Item5913,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5914")]
        Item5914,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5915")]
        Item5915,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5916")]
        Item5916,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5917")]
        Item5917,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5918")]
        Item5918,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5919")]
        Item5919,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5920")]
        Item5920,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5921")]
        Item5921,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5922")]
        Item5922,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5923")]
        Item5923,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5924")]
        Item5924,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5925")]
        Item5925,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5926")]
        Item5926,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5927")]
        Item5927,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5928")]
        Item5928,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5929")]
        Item5929,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5931")]
        Item5931,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5932")]
        Item5932,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5933")]
        Item5933,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5934")]
        Item5934,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5949")]
        Item5949,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6101")]
        Item6101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6102")]
        Item6102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6103")]
        Item6103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6104")]
        Item6104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6105")]
        Item6105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6106")]
        Item6106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6107")]
        Item6107,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6108")]
        Item6108,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6109")]
        Item6109,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6110")]
        Item6110,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6111")]
        Item6111,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6112")]
        Item6112,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6113")]
        Item6113,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6114")]
        Item6114,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6115")]
        Item6115,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6116")]
        Item6116,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6117")]
        Item6117,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6118")]
        Item6118,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6119")]
        Item6119,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6120")]
        Item6120,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6122")]
        Item6122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6123")]
        Item6123,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6124")]
        Item6124,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6125")]
        Item6125,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6151")]
        Item6151,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6152")]
        Item6152,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6153")]
        Item6153,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6155")]
        Item6155,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6156")]
        Item6156,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6201")]
        Item6201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6202")]
        Item6202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6205")]
        Item6205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6206")]
        Item6206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6207")]
        Item6207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6208")]
        Item6208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6209")]
        Item6209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6210")]
        Item6210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6251")]
        Item6251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6252")]
        Item6252,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6253")]
        Item6253,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6254")]
        Item6254,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6255")]
        Item6255,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6256")]
        Item6256,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6257")]
        Item6257,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6258")]
        Item6258,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6401")]
        Item6401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6402")]
        Item6402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6403")]
        Item6403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6404")]
        Item6404,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6408")]
        Item6408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6409")]
        Item6409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6410")]
        Item6410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6411")]
        Item6411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6412")]
        Item6412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6413")]
        Item6413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6414")]
        Item6414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6415")]
        Item6415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6501")]
        Item6501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6502")]
        Item6502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6503")]
        Item6503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6504")]
        Item6504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6505")]
        Item6505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6551")]
        Item6551,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6552")]
        Item6552,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6553")]
        Item6553,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6554")]
        Item6554,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6555")]
        Item6555,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6556")]
        Item6556,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6557")]
        Item6557,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6603")]
        Item6603,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6651")]
        Item6651,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6652")]
        Item6652,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6653")]
        Item6653,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6654")]
        Item6654,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6655")]
        Item6655,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6656")]
        Item6656,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6657")]
        Item6657,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6658")]
        Item6658,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6659")]
        Item6659,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6660")]
        Item6660,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6661")]
        Item6661,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6662")]
        Item6662,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6663")]
        Item6663,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6664")]
        Item6664,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6665")]
        Item6665,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6666")]
        Item6666,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6667")]
        Item6667,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6901")]
        Item6901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6902")]
        Item6902,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6903")]
        Item6903,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6904")]
        Item6904,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6905")]
        Item6905,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6906")]
        Item6906,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6907")]
        Item6907,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6908")]
        Item6908,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6909")]
        Item6909,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6910")]
        Item6910,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6911")]
        Item6911,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6912")]
        Item6912,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6913")]
        Item6913,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6914")]
        Item6914,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6915")]
        Item6915,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6916")]
        Item6916,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6917")]
        Item6917,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6918")]
        Item6918,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6919")]
        Item6919,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6920")]
        Item6920,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6921")]
        Item6921,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6922")]
        Item6922,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6923")]
        Item6923,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6924")]
        Item6924,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6925")]
        Item6925,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6929")]
        Item6929,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6931")]
        Item6931,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6932")]
        Item6932,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6933")]
        Item6933,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6934")]
        Item6934,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6949")]
        Item6949,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7101")]
        Item7101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7102")]
        Item7102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7105")]
        Item7105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7106")]
        Item7106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7127")]
        Item7127,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7201")]
        Item7201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7202")]
        Item7202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7205")]
        Item7205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7206")]
        Item7206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7207")]
        Item7207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7210")]
        Item7210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7211")]
        Item7211,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7251")]
        Item7251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7501")]
        Item7501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7551")]
        Item7551,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7553")]
        Item7553,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7556")]
        Item7556,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7651")]
        Item7651,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7654")]
        Item7654,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7667")]
        Item7667,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7930")]
        Item7930,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7949")]
        Item7949,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdIndTot
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDI
    {

        private string nDIField;

        private string dDIField;

        private string xLocDesembField;

        private TUfEmi uFDesembField;

        private string dDesembField;

        private string cExportadorField;

        private TNFeInfNFeDetProdDIAdi[] adiField;

        /// <remarks/>
        public string nDI
        {
            get
            {
                return this.nDIField;
            }
            set
            {
                this.nDIField = value;
            }
        }

        /// <remarks/>
        public string dDI
        {
            get
            {
                return this.dDIField;
            }
            set
            {
                this.dDIField = value;
            }
        }

        /// <remarks/>
        public string xLocDesemb
        {
            get
            {
                return this.xLocDesembField;
            }
            set
            {
                this.xLocDesembField = value;
            }
        }

        /// <remarks/>
        public TUfEmi UFDesemb
        {
            get
            {
                return this.uFDesembField;
            }
            set
            {
                this.uFDesembField = value;
            }
        }

        /// <remarks/>
        public string dDesemb
        {
            get
            {
                return this.dDesembField;
            }
            set
            {
                this.dDesembField = value;
            }
        }

        /// <remarks/>
        public string cExportador
        {
            get
            {
                return this.cExportadorField;
            }
            set
            {
                this.cExportadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("adi")]
        public TNFeInfNFeDetProdDIAdi[] adi
        {
            get
            {
                return this.adiField;
            }
            set
            {
                this.adiField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDIAdi
    {

        private string nAdicaoField;

        private string nSeqAdicField;

        private string cFabricanteField;

        private string vDescDIField;

        /// <remarks/>
        public string nAdicao
        {
            get
            {
                return this.nAdicaoField;
            }
            set
            {
                this.nAdicaoField = value;
            }
        }

        /// <remarks/>
        public string nSeqAdic
        {
            get
            {
                return this.nSeqAdicField;
            }
            set
            {
                this.nSeqAdicField = value;
            }
        }

        /// <remarks/>
        public string cFabricante
        {
            get
            {
                return this.cFabricanteField;
            }
            set
            {
                this.cFabricanteField = value;
            }
        }

        /// <remarks/>
        public string vDescDI
        {
            get
            {
                return this.vDescDIField;
            }
            set
            {
                this.vDescDIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdArma
    {

        private TNFeInfNFeDetProdArmaTpArma tpArmaField;

        private string nSerieField;

        private string nCanoField;

        private string descrField;

        /// <remarks/>
        public TNFeInfNFeDetProdArmaTpArma tpArma
        {
            get
            {
                return this.tpArmaField;
            }
            set
            {
                this.tpArmaField = value;
            }
        }

        /// <remarks/>
        public string nSerie
        {
            get
            {
                return this.nSerieField;
            }
            set
            {
                this.nSerieField = value;
            }
        }

        /// <remarks/>
        public string nCano
        {
            get
            {
                return this.nCanoField;
            }
            set
            {
                this.nCanoField = value;
            }
        }

        /// <remarks/>
        public string descr
        {
            get
            {
                return this.descrField;
            }
            set
            {
                this.descrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdArmaTpArma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdComb
    {

        private string cProdANPField;

        private string cODIFField;

        private string qTempField;

        private TUf uFConsField;

        private TNFeInfNFeDetProdCombCIDE cIDEField;

        /// <remarks/>
        public string cProdANP
        {
            get
            {
                return this.cProdANPField;
            }
            set
            {
                this.cProdANPField = value;
            }
        }

        /// <remarks/>
        public string CODIF
        {
            get
            {
                return this.cODIFField;
            }
            set
            {
                this.cODIFField = value;
            }
        }

        /// <remarks/>
        public string qTemp
        {
            get
            {
                return this.qTempField;
            }
            set
            {
                this.qTempField = value;
            }
        }

        /// <remarks/>
        public TUf UFCons
        {
            get
            {
                return this.uFConsField;
            }
            set
            {
                this.uFConsField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdCombCIDE CIDE
        {
            get
            {
                return this.cIDEField;
            }
            set
            {
                this.cIDEField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdCombCIDE
    {

        private string qBCProdField;

        private string vAliqProdField;

        private string vCIDEField;

        /// <remarks/>
        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        /// <remarks/>
        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        /// <remarks/>
        public string vCIDE
        {
            get
            {
                return this.vCIDEField;
            }
            set
            {
                this.vCIDEField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdMed
    {

        private string nLoteField;

        private string qLoteField;

        private string dFabField;

        private string dValField;

        private string vPMCField;

        /// <remarks/>
        public string nLote
        {
            get
            {
                return this.nLoteField;
            }
            set
            {
                this.nLoteField = value;
            }
        }

        /// <remarks/>
        public string qLote
        {
            get
            {
                return this.qLoteField;
            }
            set
            {
                this.qLoteField = value;
            }
        }

        /// <remarks/>
        public string dFab
        {
            get
            {
                return this.dFabField;
            }
            set
            {
                this.dFabField = value;
            }
        }

        /// <remarks/>
        public string dVal
        {
            get
            {
                return this.dValField;
            }
            set
            {
                this.dValField = value;
            }
        }

        /// <remarks/>
        public string vPMC
        {
            get
            {
                return this.vPMCField;
            }
            set
            {
                this.vPMCField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdVeicProd
    {

        private TNFeInfNFeDetProdVeicProdTpOp tpOpField;

        private string chassiField;

        private string cCorField;

        private string xCorField;

        private string potField;

        private string cilinField;

        private string pesoLField;

        private string pesoBField;

        private string nSerieField;

        private string tpCombField;

        private string nMotorField;

        private string cMTField;

        private string distField;

        private string anoModField;

        private string anoFabField;

        private string tpPintField;

        private string tpVeicField;

        private string espVeicField;

        private TNFeInfNFeDetProdVeicProdVIN vINField;

        private TNFeInfNFeDetProdVeicProdCondVeic condVeicField;

        private string cModField;

        private string cCorDENATRANField;

        private string lotaField;

        private TNFeInfNFeDetProdVeicProdTpRest tpRestField;

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdTpOp tpOp
        {
            get
            {
                return this.tpOpField;
            }
            set
            {
                this.tpOpField = value;
            }
        }

        /// <remarks/>
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
            }
        }

        /// <remarks/>
        public string cCor
        {
            get
            {
                return this.cCorField;
            }
            set
            {
                this.cCorField = value;
            }
        }

        /// <remarks/>
        public string xCor
        {
            get
            {
                return this.xCorField;
            }
            set
            {
                this.xCorField = value;
            }
        }

        /// <remarks/>
        public string pot
        {
            get
            {
                return this.potField;
            }
            set
            {
                this.potField = value;
            }
        }

        /// <remarks/>
        public string cilin
        {
            get
            {
                return this.cilinField;
            }
            set
            {
                this.cilinField = value;
            }
        }

        /// <remarks/>
        public string pesoL
        {
            get
            {
                return this.pesoLField;
            }
            set
            {
                this.pesoLField = value;
            }
        }

        /// <remarks/>
        public string pesoB
        {
            get
            {
                return this.pesoBField;
            }
            set
            {
                this.pesoBField = value;
            }
        }

        /// <remarks/>
        public string nSerie
        {
            get
            {
                return this.nSerieField;
            }
            set
            {
                this.nSerieField = value;
            }
        }

        /// <remarks/>
        public string tpComb
        {
            get
            {
                return this.tpCombField;
            }
            set
            {
                this.tpCombField = value;
            }
        }

        /// <remarks/>
        public string nMotor
        {
            get
            {
                return this.nMotorField;
            }
            set
            {
                this.nMotorField = value;
            }
        }

        /// <remarks/>
        public string CMT
        {
            get
            {
                return this.cMTField;
            }
            set
            {
                this.cMTField = value;
            }
        }

        /// <remarks/>
        public string dist
        {
            get
            {
                return this.distField;
            }
            set
            {
                this.distField = value;
            }
        }

        /// <remarks/>
        public string anoMod
        {
            get
            {
                return this.anoModField;
            }
            set
            {
                this.anoModField = value;
            }
        }

        /// <remarks/>
        public string anoFab
        {
            get
            {
                return this.anoFabField;
            }
            set
            {
                this.anoFabField = value;
            }
        }

        /// <remarks/>
        public string tpPint
        {
            get
            {
                return this.tpPintField;
            }
            set
            {
                this.tpPintField = value;
            }
        }

        /// <remarks/>
        public string tpVeic
        {
            get
            {
                return this.tpVeicField;
            }
            set
            {
                this.tpVeicField = value;
            }
        }

        /// <remarks/>
        public string espVeic
        {
            get
            {
                return this.espVeicField;
            }
            set
            {
                this.espVeicField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdVIN VIN
        {
            get
            {
                return this.vINField;
            }
            set
            {
                this.vINField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdCondVeic condVeic
        {
            get
            {
                return this.condVeicField;
            }
            set
            {
                this.condVeicField = value;
            }
        }

        /// <remarks/>
        public string cMod
        {
            get
            {
                return this.cModField;
            }
            set
            {
                this.cModField = value;
            }
        }

        /// <remarks/>
        public string cCorDENATRAN
        {
            get
            {
                return this.cCorDENATRANField;
            }
            set
            {
                this.cCorDENATRANField = value;
            }
        }

        /// <remarks/>
        public string lota
        {
            get
            {
                return this.lotaField;
            }
            set
            {
                this.lotaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdTpRest tpRest
        {
            get
            {
                return this.tpRestField;
            }
            set
            {
                this.tpRestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpOp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdVIN
    {

        /// <remarks/>
        R,

        /// <remarks/>
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdCondVeic
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpRest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImposto
    {
        private string vTotTribField;

        private object[] itemsField;

        private TNFeInfNFeDetImpostoPIS pISField;

        private TNFeInfNFeDetImpostoPISST pISSTField;

        private TNFeInfNFeDetImpostoCOFINS cOFINSField;

        private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;

        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
        [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
        [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TNFeInfNFeDetImpostoIPI))]
        [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoPIS PIS
        {
            get
            {
                return this.pISField;
            }
            set
            {
                this.pISField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISST PISST
        {
            get
            {
                return this.pISSTField;
            }
            set
            {
                this.pISSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINS COFINS
        {
            get
            {
                return this.cOFINSField;
            }
            set
            {
                this.cOFINSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSST COFINSST
        {
            get
            {
                return this.cOFINSSTField;
            }
            set
            {
                this.cOFINSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMS
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS00
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS00CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS00ModBC modBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS00CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum Torig
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS10
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS10CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS10ModBC modBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS10CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS20
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS20CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS20ModBC modBCField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS20CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS30
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS30CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS30CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS40
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS40CST cSTField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMSField;

        private bool motDesICMSFieldSpecified;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS40CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool motDesICMSSpecified
        {
            get
            {
                return this.motDesICMSFieldSpecified;
            }
            set
            {
                this.motDesICMSFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS51
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS51CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS51ModBC modBCField;

        private bool modBCFieldSpecified;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS51CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modBCSpecified
        {
            get
            {
                return this.modBCFieldSpecified;
            }
            set
            {
                this.modBCFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS60
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS60CST cSTField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS60CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS60CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS70
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS70CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS70ModBC modBCField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS70CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS90
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS90CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS90ModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS90CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSPart
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSPartCST cSTField;

        private TNFeInfNFeDetImpostoICMSICMSPartModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pBCOpField;

        private TUf uFSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSPartCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string pBCOp
        {
            get
            {
                return this.pBCOpField;
            }
            set
            {
                this.pBCOpField = value;
            }
        }

        /// <remarks/>
        public TUf UFST
        {
            get
            {
                return this.uFSTField;
            }
            set
            {
                this.uFSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN101CSOSN cSOSNField;

        private string pCredSNField;

        private string vCredICMSSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        /// <remarks/>
        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        /// <remarks/>
        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("101")]
        Item101,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN102CSOSN cSOSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        Item102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        Item103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN201CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pCredSNField;

        private string vCredICMSSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        /// <remarks/>
        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201")]
        Item201,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN202CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("202")]
        Item202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("203")]
        Item203,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN500CSOSN cSOSNField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        /// <remarks/>
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("500")]
        Item500,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN900CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pCredSNField;

        private string vCredICMSSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        /// <remarks/>
        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("900")]
        Item900,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSST
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSTCST cSTField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        private string vBCSTDestField;

        private string vICMSSTDestField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }

        /// <remarks/>
        public string vBCSTDest
        {
            get
            {
                return this.vBCSTDestField;
            }
            set
            {
                this.vBCSTDestField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTDest
        {
            get
            {
                return this.vICMSSTDestField;
            }
            set
            {
                this.vICMSSTDestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoII
    {

        private string vBCField;

        private string vDespAduField;

        private string vIIField;

        private string vIOFField;

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string vDespAdu
        {
            get
            {
                return this.vDespAduField;
            }
            set
            {
                this.vDespAduField = value;
            }
        }

        /// <remarks/>
        public string vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        /// <remarks/>
        public string vIOF
        {
            get
            {
                return this.vIOFField;
            }
            set
            {
                this.vIOFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoIPI
    {

        private string clEnqField;

        private string cNPJProdField;

        private string cSeloField;

        private string qSeloField;

        private string cEnqField;

        private object itemField;

        /// <remarks/>
        public string clEnq
        {
            get
            {
                return this.clEnqField;
            }
            set
            {
                this.clEnqField = value;
            }
        }

        /// <remarks/>
        public string CNPJProd
        {
            get
            {
                return this.cNPJProdField;
            }
            set
            {
                this.cNPJProdField = value;
            }
        }

        /// <remarks/>
        public string cSelo
        {
            get
            {
                return this.cSeloField;
            }
            set
            {
                this.cSeloField = value;
            }
        }

        /// <remarks/>
        public string qSelo
        {
            get
            {
                return this.qSeloField;
            }
            set
            {
                this.qSeloField = value;
            }
        }

        /// <remarks/>
        public string cEnq
        {
            get
            {
                return this.cEnqField;
            }
            set
            {
                this.cEnqField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IPINT", typeof(TNFeInfNFeDetImpostoIPIIPINT))]
        [System.Xml.Serialization.XmlElementAttribute("IPITrib", typeof(TNFeInfNFeDetImpostoIPIIPITrib))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoIPIIPINT
    {

        private TNFeInfNFeDetImpostoIPIIPINTCST cSTField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoIPIIPINTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoIPIIPINTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoIPIIPITrib
    {

        private TNFeInfNFeDetImpostoIPIIPITribCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string vIPIField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoIPIIPITribCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pIPI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qUnid", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vUnid", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoIPIIPITribCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        pIPI,

        /// <remarks/>
        qUnid,

        /// <remarks/>
        vBC,

        /// <remarks/>
        vUnid,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoISSQN
    {

        private string vBCField;

        private string vAliqField;

        private string vISSQNField;

        private string cMunFGField;

        private TCListServ cListServField;

        private TNFeInfNFeDetImpostoISSQNCSitTrib cSitTribField;

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string vAliq
        {
            get
            {
                return this.vAliqField;
            }
            set
            {
                this.vAliqField = value;
            }
        }

        /// <remarks/>
        public string vISSQN
        {
            get
            {
                return this.vISSQNField;
            }
            set
            {
                this.vISSQNField = value;
            }
        }

        /// <remarks/>
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        /// <remarks/>
        public TCListServ cListServ
        {
            get
            {
                return this.cListServField;
            }
            set
            {
                this.cListServField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoISSQNCSitTrib cSitTrib
        {
            get
            {
                return this.cSitTribField;
            }
            set
            {
                this.cSitTribField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCListServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("101")]
        Item101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        Item102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        Item103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("104")]
        Item104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("105")]
        Item105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("106")]
        Item106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("107")]
        Item107,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("108")]
        Item108,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201")]
        Item201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("302")]
        Item302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("303")]
        Item303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("304")]
        Item304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("305")]
        Item305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("401")]
        Item401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("402")]
        Item402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("403")]
        Item403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("404")]
        Item404,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("405")]
        Item405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("406")]
        Item406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("407")]
        Item407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("408")]
        Item408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("409")]
        Item409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("410")]
        Item410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("411")]
        Item411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("412")]
        Item412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("413")]
        Item413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("414")]
        Item414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("415")]
        Item415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("416")]
        Item416,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("417")]
        Item417,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("418")]
        Item418,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("419")]
        Item419,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("420")]
        Item420,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("421")]
        Item421,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("422")]
        Item422,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("423")]
        Item423,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("501")]
        Item501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("502")]
        Item502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("503")]
        Item503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("504")]
        Item504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("505")]
        Item505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("506")]
        Item506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("507")]
        Item507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("508")]
        Item508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("509")]
        Item509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("601")]
        Item601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("602")]
        Item602,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("603")]
        Item603,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("604")]
        Item604,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("605")]
        Item605,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("701")]
        Item701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("702")]
        Item702,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("703")]
        Item703,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("704")]
        Item704,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("705")]
        Item705,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("706")]
        Item706,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("707")]
        Item707,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("708")]
        Item708,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("709")]
        Item709,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("710")]
        Item710,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("711")]
        Item711,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("712")]
        Item712,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("713")]
        Item713,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("716")]
        Item716,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("717")]
        Item717,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("718")]
        Item718,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("719")]
        Item719,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("720")]
        Item720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("721")]
        Item721,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("722")]
        Item722,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("801")]
        Item801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("802")]
        Item802,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("901")]
        Item901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("902")]
        Item902,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("903")]
        Item903,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1001")]
        Item1001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1002")]
        Item1002,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1003")]
        Item1003,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1004")]
        Item1004,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1005")]
        Item1005,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1006")]
        Item1006,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1007")]
        Item1007,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1008")]
        Item1008,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1009")]
        Item1009,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1010")]
        Item1010,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1101")]
        Item1101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1102")]
        Item1102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1103")]
        Item1103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1104")]
        Item1104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1201")]
        Item1201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1202")]
        Item1202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1203")]
        Item1203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1204")]
        Item1204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1205")]
        Item1205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1206")]
        Item1206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1207")]
        Item1207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1208")]
        Item1208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1209")]
        Item1209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1210")]
        Item1210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1211")]
        Item1211,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1212")]
        Item1212,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1213")]
        Item1213,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1214")]
        Item1214,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1215")]
        Item1215,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1216")]
        Item1216,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1217")]
        Item1217,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1302")]
        Item1302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1303")]
        Item1303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1304")]
        Item1304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1305")]
        Item1305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1401")]
        Item1401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1402")]
        Item1402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1403")]
        Item1403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1404")]
        Item1404,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1405")]
        Item1405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1406")]
        Item1406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1407")]
        Item1407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1408")]
        Item1408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1409")]
        Item1409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1410")]
        Item1410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1411")]
        Item1411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1412")]
        Item1412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1413")]
        Item1413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1501")]
        Item1501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1502")]
        Item1502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1503")]
        Item1503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1504")]
        Item1504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1505")]
        Item1505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1506")]
        Item1506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1507")]
        Item1507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1508")]
        Item1508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1509")]
        Item1509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1510")]
        Item1510,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1511")]
        Item1511,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1512")]
        Item1512,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1513")]
        Item1513,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1514")]
        Item1514,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1515")]
        Item1515,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1516")]
        Item1516,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1517")]
        Item1517,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1518")]
        Item1518,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1601")]
        Item1601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1701")]
        Item1701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1702")]
        Item1702,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1703")]
        Item1703,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1704")]
        Item1704,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1705")]
        Item1705,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1706")]
        Item1706,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1708")]
        Item1708,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1709")]
        Item1709,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1710")]
        Item1710,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1711")]
        Item1711,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1712")]
        Item1712,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1713")]
        Item1713,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1714")]
        Item1714,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1715")]
        Item1715,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1716")]
        Item1716,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1717")]
        Item1717,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1718")]
        Item1718,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1719")]
        Item1719,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1720")]
        Item1720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1721")]
        Item1721,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1722")]
        Item1722,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1723")]
        Item1723,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1724")]
        Item1724,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1801")]
        Item1801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1901")]
        Item1901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2001")]
        Item2001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2002")]
        Item2002,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2003")]
        Item2003,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2101")]
        Item2101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2201")]
        Item2201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2301")]
        Item2301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2401")]
        Item2401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2501")]
        Item2501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2502")]
        Item2502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2503")]
        Item2503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2504")]
        Item2504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2601")]
        Item2601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2701")]
        Item2701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2801")]
        Item2801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2901")]
        Item2901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3001")]
        Item3001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3101")]
        Item3101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3201")]
        Item3201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3301")]
        Item3301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3401")]
        Item3401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3501")]
        Item3501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3601")]
        Item3601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3701")]
        Item3701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3801")]
        Item3801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3901")]
        Item3901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4001")]
        Item4001,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNCSitTrib
    {

        /// <remarks/>
        N,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        I,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPIS
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq))]
        [System.Xml.Serialization.XmlElementAttribute("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT))]
        [System.Xml.Serialization.XmlElementAttribute("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr))]
        [System.Xml.Serialization.XmlElementAttribute("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISAliq
    {

        private TNFeInfNFeDetImpostoPISPISAliqCST cSTField;

        private string vBCField;

        private string pPISField;

        private string vPISField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISAliqCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pPIS
        {
            get
            {
                return this.pPISField;
            }
            set
            {
                this.pPISField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISAliqCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISNT
    {

        private TNFeInfNFeDetImpostoPISPISNTCST cSTField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISNTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISNTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISOutr
    {

        private TNFeInfNFeDetImpostoPISPISOutrCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private string vPISField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISOutrCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISOutrCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        pPIS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISQtde
    {

        private TNFeInfNFeDetImpostoPISPISQtdeCST cSTField;

        private string qBCProdField;

        private string vAliqProdField;

        private string vPISField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISQtdeCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        /// <remarks/>
        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISST
    {

        private string[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string vPISField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        pPIS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINS
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST cSTField;

        private string vBCField;

        private string pCOFINSField;

        private string vCOFINSField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pCOFINS
        {
            get
            {
                return this.pCOFINSField;
            }
            set
            {
                this.pCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSNTCST cSTField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        private string vCOFINSField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {

        /// <remarks/>
        pCOFINS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST cSTField;

        private string qBCProdField;

        private string vAliqProdField;

        private string vCOFINSField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        /// <remarks/>
        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSST
    {

        private string[] itemsField;

        private ItemsChoiceType4[] itemsElementNameField;

        private string vCOFINSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType4[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {

        /// <remarks/>
        pCOFINS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotal
    {

        private TNFeInfNFeTotalICMSTot iCMSTotField;

        private TNFeInfNFeTotalISSQNtot iSSQNtotField;

        private TNFeInfNFeTotalRetTrib retTribField;

        /// <remarks/>
        public TNFeInfNFeTotalICMSTot ICMSTot
        {
            get
            {
                return this.iCMSTotField;
            }
            set
            {
                this.iCMSTotField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTotalISSQNtot ISSQNtot
        {
            get
            {
                return this.iSSQNtotField;
            }
            set
            {
                this.iSSQNtotField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTotalRetTrib retTrib
        {
            get
            {
                return this.retTribField;
            }
            set
            {
                this.retTribField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalICMSTot
    {

        private string vBCField;

        private string vICMSField;

        private string vBCSTField;

        private string vSTField;

        private string vProdField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vIIField;

        private string vIPIField;

        private string vPISField;

        private string vCOFINSField;

        private string vOutroField;

        private string vNFField;

        private string vTotTribField;


        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string vST
        {
            get
            {
                return this.vSTField;
            }
            set
            {
                this.vSTField = value;
            }
        }

        /// <remarks/>
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        /// <remarks/>
        public string vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        /// <remarks/>
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        /// <remarks/>
        public string vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        /// <remarks/>
        public string vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        /// <remarks/>
        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalISSQNtot
    {

        private string vServField;

        private string vBCField;

        private string vISSField;

        private string vPISField;

        private string vCOFINSField;

        /// <remarks/>
        public string vServ
        {
            get
            {
                return this.vServField;
            }
            set
            {
                this.vServField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string vISS
        {
            get
            {
                return this.vISSField;
            }
            set
            {
                this.vISSField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalRetTrib
    {

        private string vRetPISField;

        private string vRetCOFINSField;

        private string vRetCSLLField;

        private string vBCIRRFField;

        private string vIRRFField;

        private string vBCRetPrevField;

        private string vRetPrevField;

        /// <remarks/>
        public string vRetPIS
        {
            get
            {
                return this.vRetPISField;
            }
            set
            {
                this.vRetPISField = value;
            }
        }

        /// <remarks/>
        public string vRetCOFINS
        {
            get
            {
                return this.vRetCOFINSField;
            }
            set
            {
                this.vRetCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vRetCSLL
        {
            get
            {
                return this.vRetCSLLField;
            }
            set
            {
                this.vRetCSLLField = value;
            }
        }

        /// <remarks/>
        public string vBCIRRF
        {
            get
            {
                return this.vBCIRRFField;
            }
            set
            {
                this.vBCIRRFField = value;
            }
        }

        /// <remarks/>
        public string vIRRF
        {
            get
            {
                return this.vIRRFField;
            }
            set
            {
                this.vIRRFField = value;
            }
        }

        /// <remarks/>
        public string vBCRetPrev
        {
            get
            {
                return this.vBCRetPrevField;
            }
            set
            {
                this.vBCRetPrevField = value;
            }
        }

        /// <remarks/>
        public string vRetPrev
        {
            get
            {
                return this.vRetPrevField;
            }
            set
            {
                this.vRetPrevField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTransp
    {

        private TNFeInfNFeTranspModFrete modFreteField;

        private TNFeInfNFeTranspTransporta transportaField;

        private TNFeInfNFeTranspRetTransp retTranspField;

        private object[] itemsField;

        private ItemsChoiceType5[] itemsElementNameField;

        private TNFeInfNFeTranspVol[] volField;

        /// <remarks/>
        public TNFeInfNFeTranspModFrete modFrete
        {
            get
            {
                return this.modFreteField;
            }
            set
            {
                this.modFreteField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTranspTransporta transporta
        {
            get
            {
                return this.transportaField;
            }
            set
            {
                this.transportaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTranspRetTransp retTransp
        {
            get
            {
                return this.retTranspField;
            }
            set
            {
                this.retTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("balsa", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("reboque", typeof(TVeiculo))]
        [System.Xml.Serialization.XmlElementAttribute("vagao", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("veicTransp", typeof(TVeiculo))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType5[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vol")]
        public TNFeInfNFeTranspVol[] vol
        {
            get
            {
                return this.volField;
            }
            set
            {
                this.volField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTranspModFrete
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspTransporta
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string xNomeField;

        private string ieField;

        private string xEnderField;

        private string xMunField;

        private TUf ufField;

        private bool ufFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public string xEnder
        {
            get
            {
                return this.xEnderField;
            }
            set
            {
                this.xEnderField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFSpecified
        {
            get
            {
                return this.ufFieldSpecified;
            }
            set
            {
                this.ufFieldSpecified = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspRetTransp
    {

        private string vServField;

        private string vBCRetField;

        private string pICMSRetField;

        private string vICMSRetField;

        private TCfopTransp cFOPField;

        private string cMunFGField;

        /// <remarks/>
        public string vServ
        {
            get
            {
                return this.vServField;
            }
            set
            {
                this.vServField = value;
            }
        }

        /// <remarks/>
        public string vBCRet
        {
            get
            {
                return this.vBCRetField;
            }
            set
            {
                this.vBCRetField = value;
            }
        }

        /// <remarks/>
        public string pICMSRet
        {
            get
            {
                return this.pICMSRetField;
            }
            set
            {
                this.pICMSRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSRet
        {
            get
            {
                return this.vICMSRetField;
            }
            set
            {
                this.vICMSRetField = value;
            }
        }

        /// <remarks/>
        public TCfopTransp CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        /// <remarks/>
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCfopTransp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5351")]
        Item5351,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5352")]
        Item5352,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5353")]
        Item5353,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5354")]
        Item5354,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5355")]
        Item5355,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5356")]
        Item5356,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5357")]
        Item5357,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5359")]
        Item5359,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5360")]
        Item5360,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5931")]
        Item5931,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5932")]
        Item5932,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6351")]
        Item6351,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6352")]
        Item6352,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6353")]
        Item6353,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6354")]
        Item6354,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6355")]
        Item6355,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6356")]
        Item6356,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6357")]
        Item6357,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6359")]
        Item6359,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6360")]
        Item6360,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6931")]
        Item6931,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6932")]
        Item6932,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7358")]
        Item7358,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TVeiculo
    {

        private string placaField;

        private TUf ufField;

        private string rNTCField;

        /// <remarks/>
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public string RNTC
        {
            get
            {
                return this.rNTCField;
            }
            set
            {
                this.rNTCField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {

        /// <remarks/>
        balsa,

        /// <remarks/>
        reboque,

        /// <remarks/>
        vagao,

        /// <remarks/>
        veicTransp,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVol
    {

        private string qVolField;

        private string espField;

        private string marcaField;

        private string nVolField;

        private string pesoLField;

        private string pesoBField;

        private TNFeInfNFeTranspVolLacres[] lacresField;

        /// <remarks/>
        public string qVol
        {
            get
            {
                return this.qVolField;
            }
            set
            {
                this.qVolField = value;
            }
        }

        /// <remarks/>
        public string esp
        {
            get
            {
                return this.espField;
            }
            set
            {
                this.espField = value;
            }
        }

        /// <remarks/>
        public string marca
        {
            get
            {
                return this.marcaField;
            }
            set
            {
                this.marcaField = value;
            }
        }

        /// <remarks/>
        public string nVol
        {
            get
            {
                return this.nVolField;
            }
            set
            {
                this.nVolField = value;
            }
        }

        /// <remarks/>
        public string pesoL
        {
            get
            {
                return this.pesoLField;
            }
            set
            {
                this.pesoLField = value;
            }
        }

        /// <remarks/>
        public string pesoB
        {
            get
            {
                return this.pesoBField;
            }
            set
            {
                this.pesoBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lacres")]
        public TNFeInfNFeTranspVolLacres[] lacres
        {
            get
            {
                return this.lacresField;
            }
            set
            {
                this.lacresField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVolLacres
    {

        private string nLacreField;

        /// <remarks/>
        public string nLacre
        {
            get
            {
                return this.nLacreField;
            }
            set
            {
                this.nLacreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobr
    {

        private TNFeInfNFeCobrFat fatField;

        private TNFeInfNFeCobrDup[] dupField;

        /// <remarks/>
        public TNFeInfNFeCobrFat fat
        {
            get
            {
                return this.fatField;
            }
            set
            {
                this.fatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dup")]
        public TNFeInfNFeCobrDup[] dup
        {
            get
            {
                return this.dupField;
            }
            set
            {
                this.dupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrFat
    {

        private string nFatField;

        private string vOrigField;

        private string vDescField;

        private string vLiqField;

        /// <remarks/>
        public string nFat
        {
            get
            {
                return this.nFatField;
            }
            set
            {
                this.nFatField = value;
            }
        }

        /// <remarks/>
        public string vOrig
        {
            get
            {
                return this.vOrigField;
            }
            set
            {
                this.vOrigField = value;
            }
        }

        /// <remarks/>
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        /// <remarks/>
        public string vLiq
        {
            get
            {
                return this.vLiqField;
            }
            set
            {
                this.vLiqField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrDup
    {

        private string nDupField;

        private string dVencField;

        private string vDupField;

        /// <remarks/>
        public string nDup
        {
            get
            {
                return this.nDupField;
            }
            set
            {
                this.nDupField = value;
            }
        }

        /// <remarks/>
        public string dVenc
        {
            get
            {
                return this.dVencField;
            }
            set
            {
                this.dVencField = value;
            }
        }

        /// <remarks/>
        public string vDup
        {
            get
            {
                return this.vDupField;
            }
            set
            {
                this.vDupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdic
    {

        private string infAdFiscoField;

        private string infCplField;

        private TNFeInfNFeInfAdicObsCont[] obsContField;

        private TNFeInfNFeInfAdicObsFisco[] obsFiscoField;

        private TNFeInfNFeInfAdicProcRef[] procRefField;

        /// <remarks/>
        public string infAdFisco
        {
            get
            {
                return this.infAdFiscoField;
            }
            set
            {
                this.infAdFiscoField = value;
            }
        }

        /// <remarks/>
        public string infCpl
        {
            get
            {
                return this.infCplField;
            }
            set
            {
                //remoçao /n para NEGESYS
                //rever aplicação
                string infCplTemp = value.Replace("\n", "");

                this.infCplField = infCplTemp;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("obsCont")]
        public TNFeInfNFeInfAdicObsCont[] obsCont
        {
            get
            {
                return this.obsContField;
            }
            set
            {
                this.obsContField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("obsFisco")]
        public TNFeInfNFeInfAdicObsFisco[] obsFisco
        {
            get
            {
                return this.obsFiscoField;
            }
            set
            {
                this.obsFiscoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procRef")]
        public TNFeInfNFeInfAdicProcRef[] procRef
        {
            get
            {
                return this.procRefField;
            }
            set
            {
                this.procRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsCont
    {

        private string xTextoField;

        private string xCampoField;

        /// <remarks/>
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsFisco
    {

        private string xTextoField;

        private string xCampoField;

        /// <remarks/>
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicProcRef
    {

        private string nProcField;

        private TNFeInfNFeInfAdicProcRefIndProc indProcField;

        /// <remarks/>
        public string nProc
        {
            get
            {
                return this.nProcField;
            }
            set
            {
                this.nProcField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeInfAdicProcRefIndProc indProc
        {
            get
            {
                return this.indProcField;
            }
            set
            {
                this.indProcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeInfAdicProcRefIndProc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeExporta
    {

        private TUf uFEmbarqField;

        private string xLocEmbarqField;

        /// <remarks/>
        public TUf UFEmbarq
        {
            get
            {
                return this.uFEmbarqField;
            }
            set
            {
                this.uFEmbarqField = value;
            }
        }

        /// <remarks/>
        public string xLocEmbarq
        {
            get
            {
                return this.xLocEmbarqField;
            }
            set
            {
                this.xLocEmbarqField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCompra
    {

        private string xNEmpField;

        private string xPedField;

        private string xContField;

        /// <remarks/>
        public string xNEmp
        {
            get
            {
                return this.xNEmpField;
            }
            set
            {
                this.xNEmpField = value;
            }
        }

        /// <remarks/>
        public string xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }

        /// <remarks/>
        public string xCont
        {
            get
            {
                return this.xContField;
            }
            set
            {
                this.xContField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCana
    {

        private string safraField;

        private string refField;

        private TNFeInfNFeCanaForDia[] forDiaField;

        private string qTotMesField;

        private string qTotAntField;

        private string qTotGerField;

        private TNFeInfNFeCanaDeduc[] deducField;

        private string vForField;

        private string vTotDedField;

        private string vLiqForField;

        /// <remarks/>
        public string safra
        {
            get
            {
                return this.safraField;
            }
            set
            {
                this.safraField = value;
            }
        }

        /// <remarks/>
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("forDia")]
        public TNFeInfNFeCanaForDia[] forDia
        {
            get
            {
                return this.forDiaField;
            }
            set
            {
                this.forDiaField = value;
            }
        }

        /// <remarks/>
        public string qTotMes
        {
            get
            {
                return this.qTotMesField;
            }
            set
            {
                this.qTotMesField = value;
            }
        }

        /// <remarks/>
        public string qTotAnt
        {
            get
            {
                return this.qTotAntField;
            }
            set
            {
                this.qTotAntField = value;
            }
        }

        /// <remarks/>
        public string qTotGer
        {
            get
            {
                return this.qTotGerField;
            }
            set
            {
                this.qTotGerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deduc")]
        public TNFeInfNFeCanaDeduc[] deduc
        {
            get
            {
                return this.deducField;
            }
            set
            {
                this.deducField = value;
            }
        }

        /// <remarks/>
        public string vFor
        {
            get
            {
                return this.vForField;
            }
            set
            {
                this.vForField = value;
            }
        }

        /// <remarks/>
        public string vTotDed
        {
            get
            {
                return this.vTotDedField;
            }
            set
            {
                this.vTotDedField = value;
            }
        }

        /// <remarks/>
        public string vLiqFor
        {
            get
            {
                return this.vLiqForField;
            }
            set
            {
                this.vLiqForField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaForDia
    {

        private string qtdeField;

        private string diaField;

        /// <remarks/>
        public string qtde
        {
            get
            {
                return this.qtdeField;
            }
            set
            {
                this.qtdeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dia
        {
            get
            {
                return this.diaField;
            }
            set
            {
                this.diaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaDeduc
    {

        private string xDedField;

        private string vDedField;

        /// <remarks/>
        public string xDed
        {
            get
            {
                return this.xDedField;
            }
            set
            {
                this.xDedField = value;
            }
        }

        /// <remarks/>
        public string vDed
        {
            get
            {
                return this.vDedField;
            }
            set
            {
                this.vDedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("inutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TInutNFe
    {

        private TInutNFeInfInut infInutField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TInutNFeInfInut infInut
        {
            get
            {
                return this.infInutField;
            }
            set
            {
                this.infInutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TInutNFeInfInut
    {

        private TAmb tpAmbField;

        private TInutNFeInfInutXServ xServField;

        private TCodUfIBGE cUFField;

        private string anoField;

        private string cNPJField;

        private TMod modField;

        private string serieField;

        private string nNFIniField;

        private string nNFFinField;

        private string xJustField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public TInutNFeInfInutXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string ano
        {
            get
            {
                return this.anoField;
            }
            set
            {
                this.anoField = value;
            }
        }

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public TMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string nNFIni
        {
            get
            {
                return this.nNFIniField;
            }
            set
            {
                this.nNFIniField = value;
            }
        }

        /// <remarks/>
        public string nNFFin
        {
            get
            {
                return this.nNFFinField;
            }
            set
            {
                this.nNFFinField = value;
            }
        }

        /// <remarks/>
        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("procCancNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TProcCancNFe
    {

        private TCancNFe cancNFeField;

        private TRetCancNFe retCancNFeField;

        private string versaoField;

        /// <remarks/>
        public TCancNFe cancNFe
        {
            get
            {
                return this.cancNFeField;
            }
            set
            {
                this.cancNFeField = value;
            }
        }

        /// <remarks/>
        public TRetCancNFe retCancNFe
        {
            get
            {
                return this.retCancNFeField;
            }
            set
            {
                this.retCancNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retCancNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetCancNFe
    {

        private TRetCancNFeInfCanc infCancField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TRetCancNFeInfCanc infCanc
        {
            get
            {
                return this.infCancField;
            }
            set
            {
                this.infCancField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetCancNFeInfCanc
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string chNFeField;

        private System.DateTime dhRecbtoField;

        private bool dhRecbtoFieldSpecified;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified
        {
            get
            {
                return this.dhRecbtoFieldSpecified;
            }
            set
            {
                this.dhRecbtoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("procEventoNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TProcEvento
    {

        private TEvento eventoField;

        private TretEvento retEventoField;

        private string versaoField;

        /// <remarks/>
        public TEvento evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        /// <remarks/>
        public TretEvento retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }






    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("ProcInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TProcInutNFe
    {

        private TInutNFe inutNFeField;

        private TRetInutNFe retInutNFeField;

        private string versaoField;

        /// <remarks/>
        public TInutNFe inutNFe
        {
            get
            {
                return this.inutNFeField;
            }
            set
            {
                this.inutNFeField = value;
            }
        }

        /// <remarks/>
        public TRetInutNFe retInutNFe
        {
            get
            {
                return this.retInutNFeField;
            }
            set
            {
                this.retInutNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetInutNFe
    {

        private TRetInutNFeInfInut infInutField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TRetInutNFeInfInut infInut
        {
            get
            {
                return this.infInutField;
            }
            set
            {
                this.infInutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetInutNFeInfInut
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string anoField;

        private string cNPJField;

        private TMod modField;

        private bool modFieldSpecified;

        private string serieField;

        private string nNFIniField;

        private string nNFFinField;

        private System.DateTime dhRecbtoField;

        private bool dhRecbtoFieldSpecified;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string ano
        {
            get
            {
                return this.anoField;
            }
            set
            {
                this.anoField = value;
            }
        }

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public TMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modSpecified
        {
            get
            {
                return this.modFieldSpecified;
            }
            set
            {
                this.modFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string nNFIni
        {
            get
            {
                return this.nNFIniField;
            }
            set
            {
                this.nNFIniField = value;
            }
        }

        /// <remarks/>
        public string nNFFin
        {
            get
            {
                return this.nNFFinField;
            }
            set
            {
                this.nNFFinField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified
        {
            get
            {
                return this.dhRecbtoFieldSpecified;
            }
            set
            {
                this.dhRecbtoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TNfeProc
    {

        private TNFe nFeField;

        private TProtNFe protNFeField;

        private string versaoField;

        /// <remarks/>
        public TNFe NFe
        {
            get
            {
                return this.nFeField;
            }
            set
            {
                this.nFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public TProtNFe protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFe
    {

        private TProtNFeInfProt infProtField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TProtNFeInfProt infProt
        {
            get
            {
                return this.infProtField;
            }
            set
            {
                this.infProtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFeInfProt
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string chNFeField;

        private System.DateTime dhRecbtoField;

        private string nProtField;

        private byte[] digValField;

        private string cStatField;

        private string xMotivoField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsCad", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetConsCad
    {

        private TRetConsCadInfCons infConsField;

        private string versaoField;

        /// <remarks/>
        public TRetConsCadInfCons infCons
        {
            get
            {
                return this.infConsField;
            }
            set
            {
                this.infConsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetConsCadInfCons
    {

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TUfCons ufField;

        private string itemField;

        private ItemChoiceType9 itemElementNameField;

        private System.DateTime dhConsField;

        private TCodUfIBGE cUFField;

        private TRetConsCadInfConsInfCad[] infCadField;

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TUfCons UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("IE", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType9 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhCons
        {
            get
            {
                return this.dhConsField;
            }
            set
            {
                this.dhConsField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infCad")]
        public TRetConsCadInfConsInfCad[] infCad
        {
            get
            {
                return this.infCadField;
            }
            set
            {
                this.infCadField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType9
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        IE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetConsCadInfConsInfCad
    {

        private string ieField;

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private TUf ufField;

        private TRetConsCadInfConsInfCadCSit cSitField;

        private TRetConsCadInfConsInfCadIndCredNFe indCredNFeField;

        private TRetConsCadInfConsInfCadIndCredCTe indCredCTeField;

        private string xNomeField;

        private string xFantField;

        private string xRegApurField;

        private string cNAEField;

        private System.DateTime dIniAtivField;

        private bool dIniAtivFieldSpecified;

        private System.DateTime dUltSitField;

        private bool dUltSitFieldSpecified;

        private System.DateTime dBaixaField;

        private bool dBaixaFieldSpecified;

        private string iEUnicaField;

        private string iEAtualField;

        private TEndereco enderField;

        /// <remarks/>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public TRetConsCadInfConsInfCadCSit cSit
        {
            get
            {
                return this.cSitField;
            }
            set
            {
                this.cSitField = value;
            }
        }

        /// <remarks/>
        public TRetConsCadInfConsInfCadIndCredNFe indCredNFe
        {
            get
            {
                return this.indCredNFeField;
            }
            set
            {
                this.indCredNFeField = value;
            }
        }

        /// <remarks/>
        public TRetConsCadInfConsInfCadIndCredCTe indCredCTe
        {
            get
            {
                return this.indCredCTeField;
            }
            set
            {
                this.indCredCTeField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public string xFant
        {
            get
            {
                return this.xFantField;
            }
            set
            {
                this.xFantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string xRegApur
        {
            get
            {
                return this.xRegApurField;
            }
            set
            {
                this.xRegApurField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string CNAE
        {
            get
            {
                return this.cNAEField;
            }
            set
            {
                this.cNAEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dIniAtiv
        {
            get
            {
                return this.dIniAtivField;
            }
            set
            {
                this.dIniAtivField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dIniAtivSpecified
        {
            get
            {
                return this.dIniAtivFieldSpecified;
            }
            set
            {
                this.dIniAtivFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dUltSit
        {
            get
            {
                return this.dUltSitField;
            }
            set
            {
                this.dUltSitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dUltSitSpecified
        {
            get
            {
                return this.dUltSitFieldSpecified;
            }
            set
            {
                this.dUltSitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dBaixa
        {
            get
            {
                return this.dBaixaField;
            }
            set
            {
                this.dBaixaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dBaixaSpecified
        {
            get
            {
                return this.dBaixaFieldSpecified;
            }
            set
            {
                this.dBaixaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string IEUnica
        {
            get
            {
                return this.iEUnicaField;
            }
            set
            {
                this.iEUnicaField = value;
            }
        }

        /// <remarks/>
        public string IEAtual
        {
            get
            {
                return this.iEAtualField;
            }
            set
            {
                this.iEAtualField = value;
            }
        }

        /// <remarks/>
        public TEndereco ender
        {
            get
            {
                return this.enderField;
            }
            set
            {
                this.enderField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsCadInfConsInfCadCSit
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsCadInfConsInfCadIndCredNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsCadInfConsInfCadIndCredCTe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetConsReciNFe
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string nRecField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string cMsgField;

        private string xMsgField;

        private TProtNFe[] protNFeField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string nRec
        {
            get
            {
                return this.nRecField;
            }
            set
            {
                this.nRecField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string cMsg
        {
            get
            {
                return this.cMsgField;
            }
            set
            {
                this.cMsgField = value;
            }
        }

        /// <remarks/>
        public string xMsg
        {
            get
            {
                return this.xMsgField;
            }
            set
            {
                this.xMsgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("protNFe")]
        public TProtNFe[] protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetConsSitNFe
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string chNFeField;

        private TProtNFe protNFeField;

        private TRetCancNFe_v200107 retCancNFeField;

        private TProcEvento[] procEventoNFeField;

        private TVerConsSitNFe versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public TProtNFe protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        /// <remarks/>
        public TRetCancNFe_v200107 retCancNFe
        {
            get
            {
                return this.retCancNFeField;
            }
            set
            {
                this.retCancNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procEventoNFe")]
        public TProcEvento[] procEventoNFe
        {
            get
            {
                return this.procEventoNFeField;
            }
            set
            {
                this.procEventoNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerConsSitNFe versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retConsStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetConsStatServ
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private System.DateTime dhRecbtoField;

        private string tMedField;

        private System.DateTime dhRetornoField;

        private bool dhRetornoFieldSpecified;

        private string xObsField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public string tMed
        {
            get
            {
                return this.tMedField;
            }
            set
            {
                this.tMedField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRetorno
        {
            get
            {
                return this.dhRetornoField;
            }
            set
            {
                this.dhRetornoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dhRetornoSpecified
        {
            get
            {
                return this.dhRetornoFieldSpecified;
            }
            set
            {
                this.dhRetornoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string xObs
        {
            get
            {
                return this.xObsField;
            }
            set
            {
                this.xObsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetEnviNFe
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private System.DateTime dhRecbtoField;

        private TRetEnviNFeInfRec infRecField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public TRetEnviNFeInfRec infRec
        {
            get
            {
                return this.infRecField;
            }
            set
            {
                this.infRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEnviNFeInfRec
    {

        private string nRecField;

        private string tMedField;

        /// <remarks/>
        public string nRec
        {
            get
            {
                return this.nRecField;
            }
            set
            {
                this.nRecField = value;
            }
        }

        /// <remarks/>
        public string tMed
        {
            get
            {
                return this.tMedField;
            }
            set
            {
                this.tMedField = value;
            }
        }
    }




    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class detEvento
    {

        private detEventoDescEvento descEventoField;

        private string nProtField;

        private string xJustField;

        private detEventoVersao versaoField;

        /// <remarks/>
        public detEventoDescEvento descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public detEventoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum detEventoDescEvento
    {

        /// <remarks/>
        Cancelamento,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum detEventoVersao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
    }




    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEvento
    {

        private TRetEventoInfEvento infEventoField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TRetEventoInfEvento infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEventoInfEvento
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private TCOrgaoIBGE cOrgaoField;

        private string cStatField;

        private string xMotivoField;

        private string chNFeField;

        private string tpEventoField;

        private string xEventoField;

        private string nSeqEventoField;

        private string itemField;

        private NFeDownload.NFe.SchemaXML.ITCTypeCNPJCPFDest itemElementNameField;

        private string emailDestField;

        private string dhRegEventoField;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        /// <remarks/>
        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        /// <remarks/>
        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public NFeDownload.NFe.SchemaXML.ITCTypeCNPJCPFDest ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string emailDest
        {
            get
            {
                return this.emailDestField;
            }
            set
            {
                this.emailDestField = value;
            }
        }

        /// <remarks/>
        public string dhRegEvento
        {
            get
            {
                return this.dhRegEventoField;
            }
            set
            {
                this.dhRegEventoField = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetCancNFe_v200107
    {

        private TRetCancNFe_v200107InfCanc infCancField;

        private SignatureType signatureField;

        private TVerCancNFe_v200107 versaoField;

        /// <remarks/>
        public TRetCancNFe_v200107InfCanc infCanc
        {
            get
            {
                return this.infCancField;
            }
            set
            {
                this.infCancField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerCancNFe_v200107 versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerCancNFe_v200107
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.00")]
        Item200,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.07")]
        Item107,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetCancNFe_v200107InfCanc
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string chNFeField;

        private System.DateTime dhRecbtoField;

        private bool dhRecbtoFieldSpecified;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified
        {
            get
            {
                return this.dhRecbtoFieldSpecified;
            }
            set
            {
                this.dhRecbtoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}


