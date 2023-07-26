namespace Area_y_Perimetro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite calcular el area de un rectangulo al presionar un boton designado
    ///
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>
    private void BtnArea_Clicked(object sender, EventArgs e)
    {
        int x, y, Area;

        if (!string.IsNullOrEmpty(EntryArea.Text)
        && !string.IsNullOrEmpty(EntryArea1.Text))
        {
            x = int.Parse(EntryArea.Text);
            y = int.Parse(EntryArea1.Text);

            Area = (x * y);
            EntryAreaResultado.Text = Area.ToString();
        }
        else
        {
            DisplayAlert("Error", "Ingrese los digitos", "OK");
        }
    }

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite calcular el perimetro de un rectangulo al presionar un boton designado
    ///
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>
    private void BtnPerimetro_Clicked(object sender, EventArgs e)
    {
        int x, y, Perimetro;

        if (!string.IsNullOrEmpty(EntryPerimetro.Text)
        && !string.IsNullOrEmpty(EntryPerimetro1.Text))
        {
            x = int.Parse(EntryPerimetro.Text);
            y = int.Parse(EntryPerimetro1.Text);

            Perimetro = (y * x) * 2;
            EntryPerimetroResultado.Text = Perimetro.ToString();
        }
        else
        {
            DisplayAlert("Error", "Ingrese los digitos", "OK");
        }
    }
}

