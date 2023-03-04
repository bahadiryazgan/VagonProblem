using System.Linq;

namespace VagonProblem
{
    public class VagonProblem
    {
        public static string AntrepoYerlestir(string depoDurum, string[] gelenVagonlar)
        {
            // Parametre olarak gönderilen depoların ve gelen vagonların sayısının "tam sayı sınırını aşmayacağı" varsayıldı.
            var depoKapasitesi = 9;
            var depolar = depoDurum.Replace("#", "").Select(x => int.Parse(x.ToString())).ToArray();

            foreach (var vagon in gelenVagonlar)
            {
                var vagonDizisi = vagon.Select(x => int.Parse(x.ToString())).ToArray();

                for (var vagonIndeks = vagonDizisi.Length - 1; vagonIndeks >= 0; vagonIndeks--)
                {
                    if (vagonDizisi[vagonIndeks] > 0)
                    {
                        var depoIndeks = vagonIndeks + 1;
                        while (depoIndeks >= 0)
                        {
                            var ilkNokta = depoIndeks;
                            vagonDizisi[vagonIndeks]--;
                            while (depolar[depoIndeks] == depoKapasitesi)
                            {
                                depolar[depoIndeks] = 0;
                                depoIndeks--;
                            }
                            depolar[depoIndeks]++;
                            depoIndeks = ilkNokta;
                            if (vagonDizisi[vagonIndeks] == 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return string.Join("", depolar).Insert(1, "#");
        }
    }
}


