namespace TemperatureTool.ApiClients.Utilitiess
{
    public class EmvironmentContext
    {
        // 環境：「0：Dev」「1：本番」
        // ※※ リリース時にここを切り替える ※※
        // ##########################################################
        public static string ENVIRONMENT_MODE = "1";
        // ##########################################################

        // 「0：Dev」
        public static string DEV = "0";

        // 「1：本番」
        public static string RELEASE = "1";

        // ###### RELEASE ######
        /** 
         * 
         * 共通
         * 
         **/
        // APIキー
        public static string API_KEY_RELEASE = @"l8NRanVUI8smd6VmBSEI9UjXwpLtFY33Wv95F9B6";

        /** 
         * 
         * DB用
         * 
         **/
        // DBコネクション文字列
        //public static string RDS_CONNECTION_STRING_RELEASE = "Data Source=watashino-ondo.ciw5zhmqoyvc.ap-northeast-1.rds.amazonaws.com;Initial Catalog=watashino-ondo;User ID=wataonapp;Password=fvTVR!&r35yG;Convert Zero Datetime=True";
        // RDS-PROXY
        public static string RDS_CONNECTION_STRING_RELEASE = "Data Source=watashino-ondo-rds-proxy.proxy-ciw5zhmqoyvc.ap-northeast-1.rds.amazonaws.com;Initial Catalog=watashino-ondo;User ID=wataonapp;Password=fvTVR!&r35yG;Convert Zero Datetime=True";
        

        /** 
         * 
         * Token用
         * 
         **/
        // 電子署名用公開鍵
        public static string PUBLIC_KEY_RELEASE = @"MIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAyqUWk21vHh9nalW4mlRDHk16rhTj3BMtGGDYChI/c/x0fe62/IciaWVXiA+K6IKgcL8YHekCu4PpLOm3Y1RcQjcwEKq7zdONnZLcsHVGge30vXkwJua11h2fzUkVrqARBoEJpAl7oyhtDCH8dcCu397Jtq82NmdqHXGXnunDNpY1D4nnI+SZ9QKl868F/HZqwihV9Co6q7WgLz88AfNFAJ4c4p5VSTPiHtV+s1PBoBImnREBB3Fn2KN/J6oAjXX4+dNIg0aniOtySaB3OWdCNapOuOHjnv6next8bcawZZ3LG3QuZaELrBjXMCmqOI++IBJNypVu3nQx2YYrgofAnrckb6bu05ftDEws2Qjj9kMgFhoBRzvJegKPekUhlRorBv2pP6XZCIXgmxKlhlZD18cMHWAS/iVv5uPPw+dbozkmdFu3bpbLsgH8f8lY/iMtrxswbmVrhUxZq9iv0GBPsKODPK8I4DfM+I86hiR9IM0vk2DuYWFUNiV1KACb1LvTrBLVT87GMibnXcnWUyvwbemt1F+Si4LqMU+2rQRa+mvPjrk4lba6zbYyYWokFqFt9dUXIF5sIbEN0uX6LlheRGSIyXhyn4NNAkWLESLOTdGS/ffzguF+87Um3Xwar03o6Zl54oaAb84gqNCFhg1GBdIQDvJNx/WzvlSBIu9uX4ECAwEAAQ==";
        // 暗号化用秘密鍵
        public static string PRIVATE_KEY_RELEASE = @"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";

        /** 
         * 
         * Token(AES)用
         * 
         **/
        // 初期化ベクター
        public static string IV_RELEASE = @"eqNmwqUPFNBkQJBp";
        // 鍵
        public static string KEY_RELEASE = @"33b3aMVd7ETwHzGC";

        /** 
         * 
         * PDS用
         * 
         **/
        // 公開鍵
        public static string PDS_PUBLIC_KEY_RELEASE = @"MIICITANBgkqhkiG9w0BAQEFAAOCAg4AMIICCQKCAgDFEbCK+DozejO6KS2W4dtXaxp7L3hlPS1oyn/MyHyULiz1uRMpsgizkBU7grhRo6KKbUYuKcfhaFgY+lvCFRX1ou1QCN1xnPPywUeC46RGIN7Kgng6pTG5R3jhMOipHouLAcadL0rQrldgT7B5ghxsmIEEsLLPfKcpKjYd086j+x69UA1j4Km779oRvYlXiXjIJWR4PqfUe0hzHqb8QoL3R3B2J9tRS5ycTfGg2fb6I745U65CLjhkByw8QodpNIgpJjw/OKFqosljJD1E27W4fAx/8QL1bI+9yzLOuDvzJZj0dftEhTXjR0YZh8dtrFgzwUiyj7NqU66BRwDztCmG9wRxQgC1KCCcvlb1O4k6AYoMBtWrEkb3NmnC1xUE6vYFdfeUA0xXMc3NcpAP/uxFvMmTkhYq8KF8r/dwsYNjplllUUUbb3uYarD5WZLyBZ+/ZaN6GKxwSTnRl8rLCcNrXpjvFRpMKMYMBGP9flvrJ5NMrUSOte4DeAawCBz1iYLG6ViEdxxuk5s54caPnMTDhPBrc6ppsorfHcpiPwOkFLrElV+bzMd4TFLq8W+UQivKVro6x8+hb9jG9MNwHhoq9m6veEYvTqnCEFEktEr/BKq8RVs/w4Cr8bVHWh0A917lmQ+1LZAovIrKtG+wAhKVCt18ukXA+79ZFqnUXxrBkQIDAQAB";
        // 秘密鍵
        public static string PDS_PRIVATE_KEY_RELEASE = @"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";
        // APIキー
        public static string PDS_API_KEY_RELEASE = @"A6gStUMahbFQLUY9nLQVNh3ZucFMvL";

        // PDS URL
        public static string PDS_URL_RELEASE = "https://wb3.cdms.jp/wataon2/api";

        // Company ID
        public static string PDS_COMPANY_ID_RELEASE = "C0000004";
        // Group ID
        public static string PDS_GROUP_ID_RELEASE = "G0000002";




        // ###### DEV ######
        /** 
         * 
         * 共通
         * 
         **/
        // APIキー
        public static string API_KEY_DEV = @"BcKlVM8tdj272PWsAgwKQ8YtrGGOIDO3avlOZij5";

        /** 
         * 
         * DB用
         * 
         **/
        // DBコネクション文字列
        public static string RDS_CONNECTION_STRING_DEV = "Data Source=watashino-ondo-dev.ccuasrfpyavm.ap-northeast-1.rds.amazonaws.com;Initial Catalog=watashino-ondo-dev;User ID=wataonapp;Password=wataonapp;Convert Zero Datetime=True";

        /** 
         * 
         * Token用
         * 
         **/
        // 電子署名用公開鍵
        public static string PUBLIC_KEY_DEV = @"MIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAyTbcgMo3NhovyXq5Vr5Mnctn9xuNZlRpg0nwR1eIReV7BttJCXYL68nbhRqpasd4aHVE/n/RHh+TEa5j/IUAmQMNytASsC3ffbgkIrQm7bSkUMykVL18CtASRSx3oPYumBJQI7mXecdUpuKjJ/QnENydkUCV8B5d+mN1DTYpDyTeb3W/+5KprQ/TPNJIEoY/ug9qk2RyTqUnNWB3nv6XUzIglWHzIgvYPjOZ65ahHNNxTnFof0GkuQsjbBW9Xh29/E7mFySJwtjOLcrLefW1HCUhxj+6z92034RDEP8BoN9z5Try4QpCgnGWw9H9x63OCAyuepvHBqw41jEFVDG6jGlf8Za/rW7rKXjTbiJzJC7mgR1P1zMlQ5qyvDF5LsJECS5kjJMX72/aMlrvQ9QST4HyOC5r0i68Gdv5zDXpLxxUtstzlJSzVFOE/YNwZdVMn1w10yr1/yDvjvwQBTNMG2BGWalDB92V+DP+be8Wnbn+tevnQH6G6/pMBU6FgawBScrtRNJmkYWV0vF+wk/k11VnoF9gNYqblsxxTY3pRat5nJ+cRXiSWhoTcd5ScOkLMwGnKfeFBWYKXHQGNNn4QtRG4XY8yomwwJlHmXeDu0x2zXvAkixMJ+/7jSJR6AOteKX2CMFaSoYvIz1tN3J8FZ9EOHSgYqMJ/yYVpIGd7DsCAwEAAQ==";
        // 暗号化用秘密鍵
        public static string PRIVATE_KEY_DEV = @"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";
        

        /** 
         * 
         * Token(AES)用
         * 
         **/
        // 初期化ベクター
        public static string IV_DEV = @"pyZeJqTaMWyFAzZa";
        // 鍵
        public static string KEY_DEV = @"LYv55vQIrpc7D9SB";

        /** 
         * 
         * PDS用
         * 
         **/
        // 公開鍵
        public static string PDS_PUBLIC_KEY_DEV = @"MIICITANBgkqhkiG9w0BAQEFAAOCAg4AMIICCQKCAgC6o3692Fu/kWQXYj6bQWndpCkNL5KZBJHP5YsiAewaXZc4q86ML6m7q7P3dPVwAE6KlhNrLKw9K/p3O6Rkzok1HFor8pu21Xo2vUCN6IVIMHKevMVTIQ2bEkscB80UrTIYDNm19s3vC48LP1ei6sD/C3wu13mUENWPfDznPRjAIC1dKw8MerwbOrLOSLjgER7uck6XSSb8ORxrGgy8PaIDjsp/EYXLKPUi1mac8V2NUqKn6RtSpAp7nzRfZl/s/9CzwvXPeimtzlwiti/uVs5X8c5egyoYD3YjcAXyA6WVonJP2XdBa8V2Wg3XdbKrPMJwrOifXBiVIFdQHEFZ9dzFG3QfEM84jYxWQMKE23ILHZ44veFteyFIu4mVq3BXrpXkHWrcnC20d2f4mKEytzsubfnvQiaFB2yfy0yW72EShvi6KF8pCmR/sWCTS1h309NPfw31zVMg0UaGmVTxyP57JmaqCvBdZRyeffY8H6wqKUZ1clCI0nG/6Mjb9bK2UHf/xl0bDbp2XNZUDn0guSdCb3J2L5yn+KTFw/imhN0hCJRzAbgd8ZOFDQ5cmjV0kd0tsgTMFL3EcBOjuFvC5Bk5qJRYygUsY/h1OIKGSVmJ1KHL7wHjkY8GX+IRP10Exa9/QxPRs+UhO57zTy1eIU/eMK/Gnd4sFpyHc5BNokIooQIDAQAB";
        // 秘密鍵
        public static string PDS_PRIVATE_KEY_DEV = @"MIIJJgKBAQACggIAuexV7LVU+2DjrW5siN+PEMErK+r/piswacgq8hKfuTuTTfb6zgNivj9wlduQGnySDd2ojMHGaJM+0wHYSbiWN0iFL2IxAL4e958TTYwu8G5+e2WqSrPzwIUaZB6hqWLDcoZx+fXUW/+UsXCOa0YGeZKdJnSimHbMOvvg5q59xaurw/gVxWyRVSURV97/XfYj0U/sLuqMf94xHz0Zqryt0gBN+FMGGJsoFh28rAsl5hx2CBjBaJdZNl2lQ1vrODbKGGze66xgz+7wW4f7bQ1021kdnoO6nCbC7WgwLUgdo7y1vJVQH1/LKHdL4/7OVBG3j1fxyXVq0aiurb7yW7d/iRSd57eQX6zCkYZUIHTuqc+AdtbIicCqFUwv04ns/DKunBKvq38Jx6vNHKy+C+XTrBLWbwUk3ePexpQuDAU1lEFNToM7DuCHjUhYlLR2Mo5jGL0RnvW0w4RZUFtuXu3xKbZSb8EePXFCagAaQQVIofKWC+JHc3ZejFBxBm1MnJJlVMIKuON5PNAu9lwbEMbNuMbhQPOqZL2fkT8Ko8tmI6dLtNOQM7XBwuVi69o0fkfn0paNtclW6uTRV4kh2hZ5h03ONCADk9BNsW3JRCQdCkmf8q0pnodx/tx8ruH0prRLQ+/Ey/Dt6YV78SUe+kl711HURb2EkvtSbGd+Th99BrkCgQMBAAECggIAjkNTwCtEWpFZxaQf8l+11ekpQpKviZO0mMysZ8xuYUs/vMGGScr3bIGYgWKfElVNYMTCKuo/ClfZE5ZuzIIslyKrnoUw39OaWHllSMpCRIEX0Q4KztyBYEe42PFDXBwRV3mejthW5Qpc2aU5pMXRQIc6LmnC3IzSWzPOdFUCMhXY+bvD1OvtDMyvR6B/oIMuBwRzwbaBSXpX9gJHuIhlLLJE9wV4Pa3Db6DTdIWXO0t92VYv7/sXLW1cfn1AMCRkYWo07PpaneDEFBWqAljwmMLI0jkTulZCg2xcqNlsrJRCL4nE5CzlhBI8hLm9YUCpR0rQ3Qk2cjTzbEkWo612LLwV4dw7erjQ+Rfw5PXZm7BWqn5Foj/BktIP6TEQtnEKM2bRbGzefh8aaMjr2vXtWCIfNhwj/B9hgPDQoNFGBrbb/skRYMzbqDdrF8HUQ6pDGjSPS8yJy9UiOQRfLPWv8G/CyHgc44Vdt2NQrmScKQ/J3JjIw9JaE8qrk7tA+uDhP1edT/TTqG4H2Pi3xB2hsYbvkfSEKGAJlkxnUgh3NBYHSDdj+kpCQfaZpcTBcWtC43Ik4NrGgYG4B2QeAGFi4pcgz4u78e62wvkFZw/FDK92kTrrxx/fC+gH3QFGFaw6+q6kYOUGHe1xvpW0qlKBIkOGoEPta6QcbrPZrwamKd0CggEA7M3bbVLbX0FjvIaF1Cj3kR/FaoKZPwC9varCefYFJme/wD/X6LVKVdxgx3dz4MHFNKbQjFJQ0P21Tn1+nBrQdXUSVxMvwXHIi4uGhEi9zwGpXp5NwFINnAjG4eJuWQVoVbkENWA5zg4hyzMIgtQct3PKbC24yOPO0xU5lklrBL1ur9ddhvrNCNNVEu437ladiC0rxRMcQtKWb30AkoNgAolrNoZzh0CuEy4xzmsQhHuEJhNFOhu2XdHPi4/8On9P+irrlFuvpyDs2feWOxuqeRzM3mAng3wt9hFIucACFc8doTe67ergFEy9vnK4O8WHJc3Ugd09HwheiWLT4cTNRwKCAQDI/pnHg9qGSKwTdUCfi014rhSaYC/KhAbVVm0YY3A7Q9TEO6rmIbXVr1mNJm7YE/1NTforzt54kUEf8g+/ISqjDAwjqQNhh33014402oct1AoqCkEx7S0s/eQ7v+6y3LnEb73lH6thkXG9np/INkg0yJmR94CTwDVLfwr/xv1e7zBUOaib/JRksT2fkXuLcn2euQUTR1bqZWCYGDcn3qGokgtMaKtgqw2uEdj5oeUS2Z2waAvhcLGfvpMiSwhHoAA2kWWr/QN6AkU6ut1dhBm+8dnaa9Q0KnB8n/cH6TeR22OIbl4N4qvmh4WnzmJ+stfMSrUTVgZ5pSim7O5KiYv/AoIBAAYr50gWHLmCzsKfDuXUm38gwNhhxvSpZEiJJsBe9QtnMMwl3c6myuUp9Su9pTt6UVVp8410p76KnisJgj83Q6+L+YpjaZ81A/D/FeZkru2yMWPR5FzaxpgGcoh4ij+vsGRrifyKIXeJTsAo+FPQi18MmX3wQxyZM061AuczyqI4/aV/i2R1LNrKBzGTG8oOX9SouLdOJDJpopoNO/KVke7+/dhR8LjZqq+9SHcEu014mp0Ta350MnCHg00z13L+1mrCq5kWOqG0bffQSA4KTosRgRValC0NE3WSRb7xjhxbZX5KIYkJ0gU1asyH2N1V7IvDrYIk7e7dHPmfpb4AjwkCggEAjQGYrtDAyL5JAimbGZKn2gb+a0MZpBC1notQY/C29szignx9q49wuqWWxKB22N5FMSuIW514k8sLjjbKd0L0X4h/J7FVruFYKyHiIRBCD5OXQeEJ1dXXgJ3ptUU0V4TkSnw+E3UBTaS0z9ttqw7x3x3wJugk6wLIINvSwpg+fpB9Lkl5EV3EWVPCsKRmsPC0UlroxZqhzjUq6+jpIO5eKR20EXnI6Tt3kGvy9UZvp6bFqtGDrDfcVP5kyIUtHNqR67ZbRqps+vaGzOn1jLq1OTEArexB5grz+Wpb6s/hbVElZbxP/ZvNDyB6UrxGey5KmIa8vAD47/Q/LcRAdEhEzwKCAQBczfT4j9crJfllJWXranSX5hw/TwYz70CUmyHKwjiU2klLXHWzK4Ot3WJIRfT8Cx9U6EGNtLxtEyW/pTmd69PQ4Lk1WuSbjjLfMCg1JPzhDf/I4nOwnNt1Z0pUgBOFmfIQsBelOpCU1LPEqZg7DG+kYoBQtjltdbufbC3g1DedZUryjGToj1STwFRG6/3gOvj4Q3kocp5dISbmDlzWR0hHFR7b1LUY+kwQ/5xXwgyMfO4cVAQPQzET3MOO4WKRva7VBN353jlQO2+cUhSBYNpaetydYUC5ijGToFvll9KR5gF5CkIs8sn2lOS6ycJVcI6EUriSegwEaB658o4kFESX";
        // APIキー
        public static string PDS_API_KEY_DEV = @"8XZqxviwVhBGJ7SybjStPsrgJuFpHT";

        // PDS URL
        public static string PDS_URL_DEV = "https://stgwb3.cdms.jp/wataon2/api";

        // Company ID
        public static string PDS_COMPANY_ID_DEV = "C0000004";
        // Group ID
        public static string PDS_GROUP_ID_DEV = "G0000002";

    }
}
