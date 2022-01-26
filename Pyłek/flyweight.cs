using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Py³ek
{
        interface Car {
        	String description();
        }


        class Audi : Car {
	        public String description(){
	        	return "Audi";
	        }
        }


        abstract class Configuration : Car {
        	protected Car car;
	        protected Configuration(Car c){
	        	this.car = c;
	        }
            public abstract String description();
        }


        class Air : Configuration {
	        public Air(Car car) : base(car){
            }

	
	        public override String description(){
		        return car.description() + " z klimatyzacj¹";
		    }
        }   


        class HotSits : Configuration {
	        public HotSits(Car car) : base(car){
	        }
	
	        public override String description(){
		        return car.description() + " z podrgzewanymi siedzeniami";
		    }
        }
}