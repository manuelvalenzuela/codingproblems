using CodingProblems;
using FluentAssertions;
using Xunit;

namespace CodingProblemsTests
{
    public class LongestPalindromeProblemTests
    {
        [Fact]
        public void EmptyString_ShouldReturnEmptyString()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("");
            result.Should().Be("");
        }
        
        [Fact]
        public void OneLetter_ShouldReturnSameOneLetter()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("a");
            result.Should().Be("a");
        }

        [Fact]
        public void TwoSameLetters_ShouldReturnTwoSameTwoLetters()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("aa");
            result.Should().Be("aa");
        }

        [Fact]
        public void TwoDifferentLetters_ShouldReturnFirstLetter()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("ab");
            result.Should().Be("a");
        }

        [Fact]
        public void ABB_ShouldReturnBB()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("abb");
            result.Should().Be("bb");
        }

        [Fact]
        public void PalindromeInput_ShouldReturnSameInput()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("abberrebba");
            result.Should().Be("abberrebba");
        }

        [Fact]
        public void NonPalindromeInput_ShouldReturnFirstLetter()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("asdfghjk");
            result.Should().Be("a");
        }

        [Fact]
        public void WordWithSubPalindromeInput_ShouldReturnSubPalindrome()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("asdfdghjk");
            result.Should().Be("dfd");
        }

        [Fact]
        public void WordWithTwoSubPalindromeInput_ShouldReturnLongestOne()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("asdfdghjjk");
            result.Should().Be("dfd");
        }

        [Fact]
        public void WordWithTwoSubPalindromeInput_ShouldReturnLongestOneV2()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("asadsfdaghrjrjk");
            result.Should().Be("asa");
        }

        [Fact]
        public void WordWithTwoSubPalindromeInput_ShouldReturnLongestOneV3()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("kjqlrzzfmlvyoshiktodnsjjp");
            result.Should().Be("zz");
        }

        [Fact]
        public void BigInput_ShouldReturnLongestOne()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("ibvjkmpyzsifuxcabqqpahjdeuzaybqsrsmbfplxycsafogotliyvhxjtkrbzqxlyfwujzhkdafhebvsdhkkdbhlhmaoxmbkqiwiusngkbdhlvxdyvnjrzvxmukvdfobzlmvnbnilnsyrgoygfdzjlymhprcpxsnxpcafctikxxybcusgjwmfklkffehbvlhvxfiddznwumxosomfbgxoruoqrhezgsgidgcfzbtdftjxeahriirqgxbhicoxavquhbkaomrroghdnfkknyigsluqebaqrtcwgmlnvmxoagisdmsokeznjsnwpxygjjptvyjjkbmkxvlivinmpnpxgmmorkasebngirckqcawgevljplkkgextudqaodwqmfljljhrujoerycoojwwgtklypicgkyaboqjfivbeqdlonxeidgxsyzugkntoevwfuxovazcyayvwbcqswzhytlmtmrtwpikgacnpkbwgfmpavzyjoxughwhvlsxsgttbcyrlkaarngeoaldsdtjncivhcfsaohmdhgbwkuemcembmlwbwquxfaiukoqvzmgoeppieztdacvwngbkcxknbytvztodbfnjhbtwpjlzuajnlzfmmujhcggpdcwdquutdiubgcvnxvgspmfumeqrofewynizvynavjzkbpkuxxvkjujectdyfwygnfsukvzflcuxxzvxzravzznpxttduajhbsyiywpqunnarabcroljwcbdydagachbobkcvudkoddldaucwruobfylfhyvjuynjrosxczgjwudpxaqwnboxgxybnngxxhibesiaxkicinikzzmonftqkcudlzfzutplbycejmkpxcygsafzkgudy");
            result.Should().Be("fklkf");
        }

        [Fact]
        public void BigInput2_ShouldReturnLongestOne()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");
            result.Should().Be("ranynar");
        }

        [Fact]
        public void BigInput3_ShouldReturnLongestOne()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("esbtzjaaijqkgmtaajpsdfiqtvxsgfvijpxrvxgfumsuprzlyvhclgkhccmcnquukivlpnjlfteljvykbddtrpmxzcrdqinsnlsteonhcegtkoszzonkwjevlasgjlcquzuhdmmkhfniozhuphcfkeobturbuoefhmtgcvhlsezvkpgfebbdbhiuwdcftenihseorykdguoqotqyscwymtjejpdzqepjkadtftzwebxwyuqwyeegwxhroaaymusddwnjkvsvrwwsmolmidoybsotaqufhepinkkxicvzrgbgsarmizugbvtzfxghkhthzpuetufqvigmyhmlsgfaaqmmlblxbqxpluhaawqkdluwfirfngbhdkjjyfsxglsnakskcbsyafqpwmwmoxjwlhjduayqyzmpkmrjhbqyhongfdxmuwaqgjkcpatgbrqdllbzodnrifvhcfvgbixbwywanivsdjnbrgskyifgvksadvgzzzuogzcukskjxbohofdimkmyqypyuexypwnjlrfpbtkqyngvxjcwvngmilgwbpcsseoywetatfjijsbcekaixvqreelnlmdonknmxerjjhvmqiztsgjkijjtcyetuygqgsikxctvpxrqtuhxreidhwcklkkjayvqdzqqapgdqaapefzjfngdvjsiiivnkfimqkkucltgavwlakcfyhnpgmqxgfyjziliyqhugphhjtlllgtlcsibfdktzhcfuallqlonbsgyyvvyarvaxmchtyrtkgekkmhejwvsuumhcfcyncgeqtltfmhtlsfswaqpmwpjwgvksvazhwyrzwhyjjdbphhjcmurdcgtbvpkhbkpirhysrpcrntetacyfvgjivhaxgpqhbjahruuejdmaghoaquhiafjqaionbrjbjksxaezosxqmncejjptcksnoq");
            result.Should().Be("yvvy");
        }

        [Fact]
        public void BigInput4_ShouldReturnLongestOne()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("mwwfjysbkebpdjyabcfkgprtxpwvhglddhmvaprcvrnuxifcrjpdgnktvmggmguiiquibmtviwjsqwtchkqgxqwljouunurcdtoeygdqmijdympcamawnlzsxucbpqtuwkjfqnzvvvigifyvymfhtppqamlgjozvebygkxawcbwtouaankxsjrteeijpuzbsfsjwxejtfrancoekxgfyangvzjkdskhssdjvkvdskjtiybqgsmpxmghvvicmjxqtxdowkjhmlnfcpbtwvtmjhnzntxyfxyinmqzivxkwigkondghzmbioelmepgfttczskvqfejfiibxjcuyevvpawybcvvxtxycrfbcnpvkzryrqujqaqhoagdmofgdcbhvlwgwmsmhomknbanvntspvvhvccedzzngdywuccxrnzbtchisdwsrfdqpcwknwqvalczznilujdrlevncdsyuhnpmheukottewtkuzhookcsvctsqwwdvfjxifpfsqxpmpwospndozcdbfhselfdltmpujlnhfzjcgnbgprvopxklmlgrlbldzpnkhvhkybpgtzipzotrgzkdrqntnuaqyaplcybqyvidwcfcuxinchretgvfaepmgilbrtxgqoddzyjmmupkjqcypdpfhpkhitfegickfszermqhkwmffdizeoprmnlzbjcwfnqyvmhtdekmfhqwaftlyydirjnojbrieutjhymfpflsfemkqsoewbojwluqdckmzixwxufrdpqnwvwpbavosnvjqxqbosctttxvsbmqpnolfmapywtpfaotzmyjwnd");
            result.Should().Be("khvhk");
        }

        [Fact]
        public void BigInput5_ShouldReturnLongestOne()
        {
            LongestPalindromeProblem longestPalindromeProblem = new();
            var result = longestPalindromeProblem.LongestPalindrome("flsuqzhtcahnyickkgtfnlyzwjuiwqiexthpzvcweqzeqpmqwkydhsfipcdrsjkefehhesubkirhalgnevjugfohwnlhbjfewiunlgmomxkafuuokesvfmcnvseixkkzekuinmcbmttzgsqeqbrtlwyqgiquyylaswlgfflrezaxtjobltcnpjsaslyviviosxorjsfncqirsjpkgajkfpoxxmvsyynbbovieoothpjgncfwcvpkvjcmrcuoronrfjcppbisqbzkgpnycqljpjlgeciaqrnqyxzedzkqpqsszovkgtcgxqgkflpmrikksaupukdvkzbltvefitdegnlmzeirotrfeaueqpzppnsjpspgomyezrlxsqlfcjrkglyvzvqakhtvfmeootbtbwfhqucbnuwznigoyatvkocqmbtqghybwrhmyvvuchjpvjckiryvjfxabezchynfxnpqaeampvaapgmvoylyutymdhvhqfmrlmzkhuhupizqiujpwzarnszrexpvgdmtoxvjygjpmiadzdcxtggwamkbwrkeplesupagievwsaaletcuxtpsxmbmeztcylsjxvhzrqizdmgjfyftpzpgxateopwvynljzffszkzzqgofdlwyknqfruhdkvmvrrjpijcjomnrjjubfccaypkpfokohvkqndptciqqiscvmpozlyyrwobeuazsawtimnawquogrohcrnmexiwvjxgwhmtpykqlcfacuadyhaotmmxevqwarppknoxthsmrrknu");
            result.Should().Be("ljpjl");
        }
    }
}