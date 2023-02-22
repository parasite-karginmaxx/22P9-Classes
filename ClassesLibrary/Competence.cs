using Classes;

namespace ClassesLibrary;

public class Competence
{
	public int code;
	public string content;
	public Speciality elprimo;
	public Competence(int code , string content , Speciality elprimo)
	{
		this.code = code;
		this.content = content;
		this.elprimo = elprimo;
	}
}
