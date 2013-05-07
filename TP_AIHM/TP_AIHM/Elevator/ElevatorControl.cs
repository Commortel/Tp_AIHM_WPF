using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP_AIHM.Elevator;
using TP_AIHM.Animation;

namespace TP_AIHM
{
    public class ElevatorControl
    {
        private MainWindow window;
        private ElevatorAbstract abstraction;
        public ToolBarView toolView { get; set; }
        public CabinView cabinView { get; set; }
        public ElevatorView elevatorView { get; set; }
        public AnimationControl animationControl { get; set; }

        public ElevatorControl() 
        {
            this.window = null;
            this.cabinView = new CabinView();
            this.elevatorView = new ElevatorView();
            this.toolView = new ToolBarView();
            this.abstraction = new ElevatorAbstract();
            this.animationControl = new AnimationControl();
        }

        public void init(MainWindow frame)
        {
            this.window = frame;
            this.window.init(this);
            this.cabinView.init(this);
            this.elevatorView.init(this);
            this.toolView.init(this);
            this.abstraction.init(this);
            this.animationControl.init(this);
        }

        public void userPushedButton(String name, bool selection)
        {

        }
    }
}
