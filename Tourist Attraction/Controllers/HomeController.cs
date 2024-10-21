using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tourist_Attraction.Models;

namespace Tourist_Attraction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<Trip> trips = new List<Trip>
            {
                new Trip {
                    Title = "�������������Ъ�ҧ �Թ ����� �ѡ����˹��? ��ҹ���ú�������!",
                    Eid = "1",
                    Url = "https://www.wongnai.com/trips/travel-koh-chang",
                    Description = "�ѹ��ҧ�����������Ъ�ҧ�ѹ ������ӡԨ������ҧ � �� ����ǹ�ӵ� ��ͧ���ͪ���Ҫ���Ź ����ҧ��ͧ��� �������˹���ʹ��� ��дӹ�ӵ�� �Ѻ�ͷ�Ի���ʹء��!\n\n���Ъ�ҧ� �ѧ��Ѵ��Ҵ �������Ƿ�������ا෾� ����ö����ǡѹ��ءĴ� ������ҹ����ѹ��ҧ�����ǡ���Ѵ������仡ѹ����¡Ѻ�Ź �������Ъ�ҧ ��ͧ仡Թ ����� �ѡ����˹? ��ҹ���ú�������!�������¤�ʧ���������Ъ�ҧ������˹��?�Wongnai Travel �͡�����Ъ�ҧ������������蹹�ӷ��� ���͹͹�ѡ����Ҵ������ҹ�� �����աԨ����ʹء � ��������º ��Դ��������ҧ���͹������ͧ�� � ���ҧ ����Ǫ���ӵ� ������ͤ��Ѥ ��ͧ�����Ҵ �������ҵԻ�Ҫ���Ź ����ҧ��ͧ��� ����鹡Ѻ��ü������˹���ʹ��� �ӹ�ӵ�鹪��С��ѧ��н٧���Ẻ���Դ �͡�ҡ����ѧ�շ��ѡ��Ъ�ҧ �����ҹ�������Ъ�ҧ ��������͡�ѹ�ա���� �Ѻ�ͧ��Ի���Թ���� �͹��Ѻ �����ʹء��͹",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2019/07/02/3c758646aa6c426ba3c6a81f57b20bd6.jpg",
      "https://img.wongnai.com/p/1600x0/2019/07/02/6a2733ab91164ac8943b77deb14fdbde.jpg",
      "https://img.wongnai.com/p/1600x0/2019/07/02/941dbb607f0742bbadd63bbbd993e187.jpg",
      "https://img.wongnai.com/p/1600x0/2019/07/02/bd1d256256c14c208d0843a345f75741.jpg"} ,
                    Tags = new List<string> {"���", "����", "�ش�����", "�����ҵ�", "��Ҵ"} ,
                },
                new Trip {
                    Title = "�Ѵ���� 10 ����������ҹ BTS ���������",
                    Eid = "2",
                    Url = "https://www.wongnai.com/trips/new-bts-route-trips",
                    Description = "BTS ����������Դ����ԡ������ 5 ʶҹշ�駷� �ҹ����ͧ����վ�Ҵ �պ��ѻവ ���Թ�������Ǥ�� � �����¡�͹��\n\n������ѹ��� �ʶҹ�����¡�Ҵ����ǒ ��ʶҹշ��������Ѻ�繷����Ҵ����� �������ҧ������¡����Ҥú��㹷������ ����������о����������ҧ��͡�� �Ҷ֧����駷���Ҩо�价ӡԨ��������ʹ�ǹ�����ش�ѹ�� ��е�ʹ�������ҹ��觡Թ���˹���¡ѹ�ա���",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2020/02/18/458b9a31b62b408d91137fbe152f7450.jpg",
      "https://img.wongnai.com/p/1600x0/2020/02/18/08bca1c784db4d7f92e93656b5376681.jpg",
      "https://img.wongnai.com/p/1600x0/2020/02/18/95bd2ca371e24436bcb24d432a86836c.jpg",
      "https://img.wongnai.com/p/1600x0/2020/02/18/68289e188ea54e00b5e9d806cfd0fc54.jpg"} ,
                    Tags = new List<string> {"����","��ҹ���","�ش�����ٻ","���������ا","��ا෾��ҹ��"} ,
                },
                new Trip {
                    Title = "����Ƿ�觷ҹ���ѹ�ź��� ���ٻ�������ͧ��ŷ�� �����պ�þ�",
                    Eid = "3",
                    Url = "https://www.wongnai.com/trips/ki-ri-burapha-sun-flower",
                    Description = "�ҹ�о������Ǩ�� �Ѻ��觷ҹ���ѹ����˭���� 30 ��� �����Ҫ������ ��������Դ�����Ҫ��֧����͹���Ҥ���ҹ�� ������Ҫ��价�� �����պ�þ� �ź���",
                    Photos = new List<string> {      "https://img.wongnai.com/p/1600x0/2019/12/27/777681c6184b498baead821895f7d7ab.jpg",
      "https://img.wongnai.com/p/1600x0/2019/12/27/10b2aaf1f0df42a98d0b482e254789ee.jpg",
      "https://img.wongnai.com/p/1600x0/2019/12/27/79e5b71efa54433b909e08bac13f27bb.jpg",
      "https://img.wongnai.com/p/1600x0/2019/12/27/939f644df3d847409a85c1b2d054af25.jpg"},
                    Tags = new List<string> {"�ش�����ٻ", "�����ٻ���", "���������ا", "�ź���"}
                },
                new Trip {
                    Title = "�������鹻� ��ҹ�յ�ͧ����ͧ����͡ ����͡ �Թ��١�з� ��ҷҧ��ҧ��͡",
                    Eid = "4",
                    Url = "https://www.wongnai.com/trips/travel-at-etong-pilok",
                    Description = "�ѧ��� ������� ��ҹ�յ�ͧ ����ͧ����͡ �����ҷ�����͡˹��˹�� �Թ����������ҹ����ͧ��ҹ���ѡ �Թ��١�зз����˹�� �ʹٷҧ��ҧ��͡ ���ǻԴ��Ի����ӵ�",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2019/12/25/54961e4326954765a80cd20e2044083d.jpg",
      "https://img.wongnai.com/p/1600x0/2019/12/25/183af5673b074e55a3842aca97676220.jpg",
      "https://img.wongnai.com/p/1600x0/2019/12/25/9bbcb032afc145d19e485defcf2067c1.jpg",
      "https://img.wongnai.com/p/1600x0/2019/12/25/2974828fdb16492da0e8f35f627ade7a.jpg",},
                    Tags = new List<string> {"�ش�����ٻ","�����ҹ","����","�����ҵ�","�����ٻ���","��ҹ�յ�ͧ����ͧ����͡","�ҭ������",}
                },
                new Trip {
                    Title = "��Ի�������������ҹ�����§���� ��������Ẻ����ͧ��Ŷ֧�����",
                    Eid = "5",
                    Url = "https://www.wongnai.com/trips/attraction-chiangmai-korea-style",
                    Description = "��Ф�����§����! ��������������Ẻ����ͧ��� ��ع����ٴ�Ѻ�ҡ�Ⱥ���ط��������ҧ�͡˭����� ������ҹ�����§�����������͹�������",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2019/10/10/3092e773cda34ca2a77373b82f7639b7.jpg",
      "https://img.wongnai.com/p/1600x0/2019/10/10/7739627a33134587827ee72f1a9c2cce.jpg",
      "https://img.wongnai.com/p/1600x0/2019/10/10/e51a7af0bd18463db0685057809368ef.jpg",
      "https://img.wongnai.com/p/1600x0/2019/10/10/49c6a0f4c25a41b08b3ca47ce410195d.jpg",},
                    Tags = new List<string> {"�ش�����ٻ", "�����ٻ���", "��ҹ���", "��§����", "����"}
                },
                new Trip {
                    Title = "�������������� �Թ ����� �ѡ����˹? �Ѵ�����ú!",
                    Eid = "6",
                    Url = "https://www.wongnai.com/trips/travel-koh-lipe",
                    Description = "��������������� �ѡ��͹���Ҵ���¢�� ��蹹�ӷ����� � �ӹ�ӵ�鹪�������§���š����� �Ѻ�ͧ��Ի���������ŧ���ШѴ���Ẻ��� � ��駡Թ ����� ��з��ѡ �դú",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2019/07/31/b3986319d85a4d85baecbacf03a519d8.jpg",
      "https://img.wongnai.com/p/1600x0/2019/07/31/9969a296fe1b452a8e64c2b7cfd58319.jpg",
      "https://img.wongnai.com/p/1600x0/2019/07/31/4edab94617f642d7ac11efd9bccb9863.jpg",
      "https://img.wongnai.com/p/1600x0/2019/07/31/58348f4c3ace47349e80e5930a7a525a.jpg",},
                    Tags = new List<string> {"����", "���", "ʵ��", "�����ҵ�"}
                },
                new Trip {
                    Title = "���������������ѹ���� � ��Ѻ 2020 ��ͧ����ի�ҿ��!",
                    Eid = "7",
                    Url = "https://www.wongnai.com/trips/travel-around-taiwan-free-visa",
                    Description = "�ҧἹ���������ѹ�� 2020 �ѹ! ����������ѹ��� ����ͧ����ի��!\n\n�ء�ѹ���᷺�������������ѡ�ҹ����ء ����ͧ������鹪��ͷ���Ե�ѹ价��Ǻ�ҹ�������ͧ ��ѧ�ҡ������ͧ�Թ��������� ��ҡ������ҡ�ͧ���鹵��Ѻ������Һ�ҧ ��Ի���о�仡Թ�����ء�������ѹ ������������ѹ������й͡���ͧ�˭� ���Ǥس�������� ����ȹ��������մ�������ء! ��з���Ӥѭ�͹�����㨴� ����ѹ����ի�� ���������觤����آ ���Ǩ��ͪ�������� �ҧ�Ź���������ѹ�ѹ!",
                    Photos = new List<string> {"https://img.wongnai.com/p/1920x0/2019/07/11/cefadd52a1424562bddf0d8fb4762d38.jpg",
      "https://img.wongnai.com/p/1920x0/2019/07/11/eee5544a928c4766a15a04852135dbbb.jpg",
      "https://img.wongnai.com/p/1920x0/2019/07/11/c725886d14b144868cf368bee07d1441.jpg",
      "https://img.wongnai.com/p/1920x0/2019/07/11/83cda5c3853443c4a1398fb3ae6b31a8.jpg",},
                    Tags = new List<string> {"�ش�����ٻ", "��ҧ�����", "����ѹ", "�����ҵ�"}
                },
                new Trip {
                    Title = "����ǭ����仡Ѻ����俪��ʹѧ����ش�Թ�ҡ 15 ����ش���~",
                    Eid = "8",
                    Url = "https://www.wongnai.com/trips/views-around-fuji",
                    Description = "��¶����ٻ������Ҵ! �������ǭ���� ������俿٨� ��Ƿ�ȹ��ͺ�����ҡ��� ������������\n\n��������ǭ���蹡��������ǡ��� �������������俿٨ԡ���˹��㹨ش���»��·ҧ�������ǫ���������� � ���Ф�����§��Ẻ������ỹ��ʷ������¹仵��Ĵ� ����Ѻ�����á ��ǹ�ҡ任������ѹ�������Һ Kawaguchiko ���� Hakone ������俿٨��ѧ���������ա�ҡ��� ��Ҩ֧�Ǻ����ش���������俪��ʹѧ��觹����� 15 �������������������ҡ���֧���ҡ ����ú��ԡ����仧��� ���ҧ�٨ԡѺ�����Һ Kawaguchiko ������ Unseen ���ҧ����俿٨ԡѺ��觪��������͡�ê�����俿٨Ԩҡ�оҹ�ǹ�����Ƿ���ش㹻����!",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2019/06/04/371f3bfad9cd46399f30c8b04c816597.jpg",
      "https://img.wongnai.com/p/1600x0/2019/06/04/93b7b555b624490680ebe7b0a16b0519.jpg",
      "https://img.wongnai.com/p/1600x0/2019/06/04/bf2c001a72314452a261bff3f039ccdc.jpg",
      "https://img.wongnai.com/p/1600x0/2019/06/04/37b377e43f344da794cb3353aeca3fcf.jpg"},
                    Tags = new List<string> {"�ش�����ٻ", "��ҧ�����", "�����", "�����ҵ�", "����"}
                },
                new Trip {
                    Title = "����ǽ������ ���Թ���ͧ㹽ѹ ���Ź�������ش�ѧ㹻����",
                    Eid = "9",
                    Url = "https://www.wongnai.com/trips/travel-around-paris-france",
                    Description = "1 � Dream Destination �ͧ������ � ����˹����鹡������ǽ������ ���з���շ�������� �ԾԸ�ѳ���ٿ��� ��� Disneyland �͡�����ҷ�Ի�������������ú!\n\n����Ѻ�÷��ͺ����������ʶһѵ¡��� ��ҹ�������� � ��Ъͻ�ԧ�ͧ�ù������Ң��й� �����ǽ������ ���Թ���ͧ㹽ѹ ���Ź�������ش�ѧ㹻���ʔ ���еͺ⨷���ش � ���� �����������ǡѺ�������Ǵѧ��ҧ � ��������� �ԾԸ�ѳ���ٿ��� ��� Disneyland Ẻ����觵����� � �Թ�����ٻ ����� �ҹ������������ � ��������ҧ��觡Ѻ��ª�� �鹾ѡ��͹ ��ǹ������ ��¸����ҵԢ�����¨��",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2019/05/23/4057d08671744f8e8fd9e939b5e60087.jpg",
      "https://img.wongnai.com/p/1600x0/2019/05/23/0176c0c06f2449849e826844733ef1e4.jpg",
      "https://img.wongnai.com/p/1600x0/2019/05/23/0e56670f9e0e43e7b26c312583ecca51.jpg",
      "https://img.wongnai.com/p/1600x0/2019/05/23/7a677ee703ab448b9ca20c847aa74ce3.jpg",},
                    Tags = new List<string> {"�ش�����ٻ", "��ҧ�����", "�������"}
                },
                new Trip {
                    Title = "����ǿԹ�Ź��Ẻ�Թ � 仿���� Husky ��� Reindeer ��� Snowmobile",
                    Eid = "10",
                    Url = "https://www.wongnai.com/trips/trip-at-finland",
                    Description = "���������ǿԹ�Ź�� ��������ʧ�˹�� �Ԩ������ҧ����������ҡ���������º! ��駢�� Husky, Reindeer �Ѻ��ʡ����з�����ҧ�س���ԵԴź ��ͧ�ͧ�ѡ����㹪��Ե\n\n˹��˹�ǹ����������������� �������ǵ�ҧ����ȷ���˹�� �й�������������ͼ������������������ǿԹ�Ź������˹���س����ԵԴź Feel like -20 �ѹ��¤�� �ҹ���͡�����ҹ������ͧ����ҡ����� 10 ��������ǡ � ��������¡�úԹ ����Ѻ�÷�������Ҩ��˹�����Թ� �й��������״����״��·����������û���ͷ������ǵ�ҧ�������� � ��͹ ���Ǥ��µ������ͧ������ǿԹ�Ź�����Ф�",
                    Photos = new List<string> {"https://img.wongnai.com/p/1600x0/2019/05/21/cd54e9c640694a95b7e0103b0ead5408.jpg",
      "https://img.wongnai.com/p/1600x0/2019/05/21/cf792ff02ab0491b9f30d67d33634f78.jpg",
      "https://img.wongnai.com/p/1600x0/2019/05/21/e87ce6e73c634532afd50dd02517fee9.jpg",
      "https://img.wongnai.com/p/1600x0/2019/05/21/ea0f93584b3c4f3ba0680fcc11bc3a13.jpg",},
                    Tags = new List<string> {"��ҧ�����", "�Թ�Ź��", "����", "�����ҵ�"}
                },
            };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string searchText = "")
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                var searchResults = trips
                    .Where(t => t.Title.Contains(searchText, System.StringComparison.OrdinalIgnoreCase) ||
                                t.Tags.Any(tag => tag.Contains(searchText, System.StringComparison.OrdinalIgnoreCase)))
                    .ToList();

                return View(searchResults);
            }
            
            return View(trips);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
