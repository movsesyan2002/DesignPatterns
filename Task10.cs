interface IBrushes {
    void Paint();
}

class PencilBrush : IBrushes {

    public void Paint() {
        Console.WriteLine("Pencil brushes painted");
    }

}

class InkBrush : IBrushes {

    public void Paint() {
        Console.WriteLine("Ink brushes painted");
    }

}

class PaintBrush : IBrushes {
    
    public void Paint() {
        Console.WriteLine("Paintbrush  painted");
    }

}


class BrushCreator {
    public static IBrushes CreateBrush(string? brush) {

        if (string.IsNullOrEmpty(brush)) {
            throw new Exception("You not take a argument");
        }

        switch(brush.ToLower()) {
            
            case "paintbrush":
            Console.WriteLine("Paintbrush is created");
            return new PaintBrush();

            case "inkbrush":
            Console.WriteLine("Inkbrush is created");
            return new InkBrush();

            case "pencilbrush":
            Console.WriteLine("Pencilbrush is created");
            return new PencilBrush();

            default:
            throw new Exception("Invalid message");
        }
    }
}