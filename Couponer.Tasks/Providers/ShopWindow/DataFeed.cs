﻿using System;
using System.Net.Http;
using Couponer.Tasks.Providers.ShopWindow;
using Couponer.Tasks.Services;
using Couponer.Tasks.Utility;

namespace Couponer.Tasks
{
    public class DataFeed : Logger
    {
        /* Public Methods. */

        public static string Download(MERCHANT merchant)
        {
            var inFile = AbstractDataFeed.DownloadFeed(String.Format(URL, (int) merchant), new HttpClient());
            return AbstractDataFeed.ExtractContents(inFile);
        }

        private const string URL = "http://datafeed.api.productserve.com/datafeed/download/apikey/18ff0b3f7fc8888344c37722b206a232/cid/97,98,142,144,146,129,595,539,147,149,613,626,135,163,168,159,169,161,167,170,137,171,548,174,183,178,179,175,172,623,139,614,189,194,141,205,198,206,203,208,199,204,201,61,62,72,73,71,74,75,76,77,78,79,63,80,82,64,83,84,85,65,86,87,88,90,89,91,67,94,33,54,53,57,58,52,603,60,56,66,128,130,133,212,207,209,210,211,68,69,213,215,217,218,219,220,221,222,70,224,225,226,227,228,229,4,5,10,11,537,12,13,19,15,14,6,551,20,21,553,22,23,24,25,26,27,7,30,29,32,619,34,8,35,618,40,38,42,9,652,45,46,651,47,48,49,50,634,230,538,233,235,238,550,240,585,239,241,556,245,242,521,576,575,579,281,283,554,285,303,286,282,287,288,173,193,637,639,640,642,643,644,641,650,177,196,379,648,181,645,384,387,646,598,611,391,393,647,395,631,602,570,600,405,187,411,412,413,414,415,416,417,649,418,419,420,99,100,101,107,110,111,113,114,115,116,118,121,127,581,624,123,594,125,421,605,604,599,422,433,530,434,435,532,533,428,474,475,476,477,423,608,437,438,440,441,442,444,445,446,447,607,424,451,448,453,449,452,450,425,455,457,459,460,456,458,426,616,463,464,465,466,467,427,625,597,473,469,617,470,429,430,615,483,484,485,487,488,529,596,431,432,489,490,361,633,362,366,367,368,371,369,363,372,373,374,377,375,536,535,364,378,380,381,365,386,390,392,394,396,397,399,402,404,407,540,542,544,546,547,246,558,247,252,559,255,248,256,265,593,258,259,260,261,262,557,249,266,267,268,269,612,251,277,250,272,270,271,273,561,560,347,348,354,350,351,352,349,355,356,357,358,359,360,586,592,588,591,589,328,629,338,493,635,495,507,563,564,567,569/mid/{0}/columns/merchant_id,merchant_name,aw_product_id,merchant_product_id,product_name,description,category_id,category_name,merchant_category,aw_deep_link,aw_image_url,search_price,currency,delivery_cost,merchant_deep_link,merchant_image_url,aw_thumb_url,brand_id,brand_name,commission_amount,commission_group,condition,delivery_time,display_price,ean,in_stock,is_hotpick,isbn,is_for_sale,language,merchant_thumb_url,model_number,mpn,parent_product_id,pre_order,product_type,promotional_text,rrp_price,specifications,stock_quantity,store_price,upc,valid_from,valid_to,warranty,web_offer/format/xml/compression/gzip/";    
    }
}
