using System.Diagnostics.Contracts;

interface IButton {
    void Print();
}

interface ITextList {
    void Print();
}

interface ICheckBox {
    void Print();
}




class DarkButton: IButton {

    public DarkButton () {

    }

    public void Print() {
        Console.WriteLine("Dark button");
    }
}

class LightButton : IButton {

    public LightButton () {

    }

    public void Print() {
        Console.WriteLine("Light button");
    }
}


class DarkTextList : ITextList {

    public DarkTextList() {

    }

    public void Print() {
        Console.WriteLine("Dark TextList");
    }
}

class LigthTextList : ITextList {

    public LigthTextList () {

    }

    public void Print() {
        Console.WriteLine("Ligth TextList");
    }
}

class DarkCheckBox : ICheckBox {

    public DarkCheckBox() {

    }

    public void Print() {
        Console.WriteLine("Dark CheckBox");
    }
}


class LigthCheckBox : ICheckBox {

    public LigthCheckBox() {

    }

    public void Print() {
        Console.WriteLine("Ligth CheckBox");
    }
}


interface GUI {
    IButton CreateButton();
    ICheckBox CreateCheckBox();
    ITextList CreateTextList();
}

class DarkTheme : GUI {
    public DarkTheme() {}

    public IButton CreateButton() {
        return new DarkButton();
    }

    public ICheckBox CreateCheckBox() {
        return new DarkCheckBox();
    }

    public ITextList CreateTextList() {
        return new DarkTextList();
    }
}

class LightTheme : GUI {
    public LightTheme() {}

    public IButton CreateButton() {
        return new LightButton();
    }

    public ICheckBox CreateCheckBox() {
        return new LigthCheckBox();
    }

    public ITextList CreateTextList() {
        return new LigthTextList();
    }
}
