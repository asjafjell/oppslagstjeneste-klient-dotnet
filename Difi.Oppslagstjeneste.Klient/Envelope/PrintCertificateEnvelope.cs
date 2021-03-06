﻿using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Difi.Oppslagstjeneste.Klient.Domene;

namespace Difi.Oppslagstjeneste.Klient.Envelope
{
    internal sealed class PrintCertificateEnvelope : OppslagstjenesteEnvelope
    {
        public PrintCertificateEnvelope(X509Certificate2 senderCertificate, string sendOnBehalfOf)
            : base(senderCertificate, sendOnBehalfOf)
        {
        }

        protected override XmlElement CreateBody()
        {
            var body = base.CreateBody();
            var element = Document.CreateElement("ns", "HentPrintSertifikatForespoersel", Navnerom.OppslagstjenesteDefinisjon);
            body.AppendChild(element);
            return body;
        }
    }
}