using QRCoder;
using System;
using System.Drawing;

namespace QrCodeModule
{
    public class QrCodeManager
    {
        public Bitmap GenerateQrCodeWithBMP(String code)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
    }
}
