using System.Text;

namespace PaymentService.Util
{
    public static class Constant
    {
        public static StringBuilder BodyEmail(StringBuilder _body) {
            StringBuilder builder = new StringBuilder();
            builder.Append("<html><head><META http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">");
            builder.Append("</head><body><div><table style=\"border-collapse:collapse;border-spacing:0;min-height:418px\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" bgcolor=\"#f2f2f2\"><tbody><tr><td align=\"center\" style=\"border-collapse:collapse;padding-top:30px;padding-bottom:30px\">");
            builder.Append("<table cellpadding=\"5\" cellspacing=\"5\" width=\"600\" bgcolor=\"white\" style=\"border-collapse:collapse;border-spacing:0\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;width:600px;padding:0px;text-align:center\"><table style=\"border-collapse:collapse;border-spacing:0;position:relative;min-height:40px;width:100%;font-family:Arial;font-size:25px;text-align:center;padding-top:20px;padding-bottom:20px;vertical-align:middle\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;padding:10px 15px;font-family:Arial\"> ");
            builder.Append("<table width=\"100%\" style=\"border-collapse:collapse;border-spacing:0;font-family:Arial\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse\"><h2 style=\"font-weight:normal;padding:0px;margin:0px;color:#666;word-wrap:break-word\">");
            builder.Append("<a style=\"text-decoration:none;display:inline-block;font-family:arial;font-size:25px;word-wrap:break-word;width:100%;text-align:center;color:rgb(102,102,102)\">");
            builder.Append("<span style=\"font-size:inherit;width:100%;text-align:center;color:#666\">");
            builder.Append("Produtos de sua Escolha");
            builder.Append("");
            builder.Append("</span></a></h2></td></tr></tbody></table></td></tr></tbody></table><table style=\"border-collapse:collapse;border-spacing:0;position:relative;min-height:40px;width:100%;padding-top:0px;padding-bottom:0px;padding-left:0px;padding-right:0px;max-width:600px;text-align:center\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;font-family:Arial;line-height:0px;padding:0px\">");
            builder.Append("<table width=\"100%\" style=\"border-collapse:collapse;border-spacing:0;font-family:Arial\">");
            builder.Append("<tbody><tr><td align=\"center\" style=\"border-collapse:collapse;padding:0;line-height:0px\">");
            builder.Append("<a style=\"text-decoration:none;font-family:arial;display:block\">");
            builder.Append("</td></tr></tbody></table></td></tr></tbody></table><table style=\"border-collapse:collapse;border-spacing:0;position:relative;min-height:40px;width:100%\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;padding:10px 15px;font-family:Arial\">");
            builder.Append("<table width=\"100%\" style=\"border-collapse:collapse;border-spacing:0;text-align:left;font-family:Arial\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse\"><div style=\"font-family:Arial;font-size:15px;line-height:170%;text-align:left;font-weight:normal;color:#666;word-wrap:break-word\">");
            builder.Append("<font color=\"#666666\"><span style=\"line-height:0;display:none\"></span><span style=\"line-height:0;display:none\">");
            builder.Append("</span>" + _body.ToString());
            builder.Append("</font><br></div></td></tr></tbody></table></td></tr></tbody></table><table ");
            builder.Append("style=\"border-collapse:collapse;border-spacing:0;position:relative;min-height:40px;width:100%;padding-top:10px;padding-bottom:10px;text-align:center\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;padding:10px 15px;font-family:Arial\">");
            builder.Append("<div style=\"font-family:Arial;text-align:center\">");
            builder.Append("<table style=\"border-collapse:collapse;border-spacing:0;font-family:Arial;font-size:15px;background-color:rgb(181,181,181);color:rgb(255,255,255);font-weight:bold;border-radius:10px;display:inline-block;text-align:center\">");
            builder.Append("<tbody style=\"display:inline-block\"><tr style=\"display:inline-block\"><td align=\"center\" style=\"border-collapse:collapse;display:inline-block;padding:15px 20px\"><a style=\"text-decoration:none;font-family:arial;color:#fff;font-weight:bold;margin:0px;padding:0px;text-align:center;font-size:15px;display:inline-block;word-wrap:break-word;width:100%\">Texto do botão</a></td></tr></tbody></table></div></td></tr></tbody></table><table style=\"border-collapse:collapse;border-spacing:0;position:relative;min-height:40px;width:100%;display:table\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;padding:10px 15px;font-family:Arial\">");
            builder.Append("<table width=\"100%\" style=\"border-collapse:collapse;border-spacing:0;font-family:Arial\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse\"><hr style=\"border-color:#bbb;border-style:dashed\">");
            builder.Append("</td></tr></tbody></table></td></tr></tbody></table><table style=\"border-collapse:collapse;border-spacing:0;position:relative;min-height:40px;width:100%\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;padding:10px 15px;font-family:Arial\">");
            builder.Append("<table width=\"170\" align=\"left\" style=\"border-collapse:collapse;border-spacing:0;font-family:Arial;margin-right:10px\">");
            builder.Append("<tbody><tr><td align=\"center\" style=\"border-collapse:collapse;padding-right:10px\">");
            builder.Append("");
            builder.Append("</td></tr></tbody></table><table width=\"300\" align=\"left\" style=\"border-collapse:collapse;border-spacing:0;font-family:Arial\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse\"><table style=\"border-collapse:collapse;border-spacing:0\">");
            builder.Append("<tbody><tr><td style=\"border-collapse:collapse;font-family:Arial;font-size:20px;line-height:25px;text-align:left;font-weight:normal;color:#666;padding-top:20px\">");
            builder.Append("<div><a style=\"text-decoration:none;display:inline-block;font-size:20px;font-weight:normal;font-family:Arial;color:#666;margin-bottom:5px;text-align:left;word-wrap:break-word;width:auto!important;line-height:30px\">Seu nome ou de sua empresa</a></div><span style=\"word-wrap:break-word;font-size:15px;font-family:Arial;line-height:25px\">Descrição ou informações para contato.</span></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table><table style=\"border-collapse:collapse;border-spacing:0;position:relative;min-height:40px;width:100%;padding:30px 0px\"><tbody><tr><td style=\"border-collapse:collapse;padding:10px 15px;font-family:Arial\"><table width=\"100%\" style=\"border-collapse:collapse;border-spacing:0;font-family:Arial\"><tbody><tr><td align=\"center\" style=\"border-collapse:collapse\"><a href=\"http://www.facebook.com\" style=\"text-decoration:none;display:inline-block;font-family:arial;width:auto!important\" target=\"_blank\">                                                                        <img src=\"http://img/facebook.png\" style=\"width:30px;height:auto\"> ");
            return builder;
        }
    }
}
