using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SmoothieInterface
{
    public class Settings : Utilities.db.Object
    {
        protected bool m_HasChanged = false;

        public static Dictionary<PropertyInfo, string> getReferences()
        {
            Dictionary<PropertyInfo, string> _dict = new Dictionary<PropertyInfo, string>();

            PropertyInfo[] props = typeof(Settings).GetProperties();
            for(int i = 0; i < props.Length; i++)
            {
                PropertyInfo prop = props[i];
               
                object[] attrs = prop.GetCustomAttributes(true);
                for (int n = 0; n < attrs.Length; n++ )
                {
                    if(attrs[n] is ReferenceAttribute)
                    {
                        string auth = ((ReferenceAttribute)attrs[n]).Reference;

                        _dict.Add(prop, auth);
                    }
                }
            }

            return _dict;
        }

        [
            System.ComponentModel.CategoryAttribute("Robot module configurations"),
            System.ComponentModel.DescriptionAttribute("Default rate ( mm/minute ) for G0 moves"),
            System.ComponentModel.DisplayNameAttribute("Default Seek Rate"),
            System.ComponentModel.DefaultValue(4000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("default_seek_rate")
        ]
        public System.Single DefaultSeekRate
        {
            get
            {
                System.Single value = 4000f;
                object obj = get("default_seek_rate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("default_seek_rate", value);
                this.NotifyPropertyChanged("DefaultSeekRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Robot module configurations"),
            System.ComponentModel.DescriptionAttribute("Arcs are cut into segments ( lines ), this is the length for these segments.  Smaller values mean more resolution, higher values mean faster computation"),
            System.ComponentModel.DisplayNameAttribute("mm/Arc Segment"),
            System.ComponentModel.DefaultValue(0.5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("mm_per_arc_segment")
        ]
        public System.Single MmPerArcSegment
        {
            get
            {
                System.Single value = 0.5f;
                object obj = get("mm_per_arc_segment");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("mm_per_arc_segment", value);
                this.NotifyPropertyChanged("MmPerArcSegment");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Robot module configurations"),
            System.ComponentModel.DescriptionAttribute("Lines can be cut into segments ( not usefull with cartesian coordinates robots )."),
            System.ComponentModel.DisplayNameAttribute("mm/Line Segment"),
            System.ComponentModel.DefaultValue(5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("mm_per_line_segment")
        ]
        public System.Single MmPerLineSegment
        {
            get
            {
                System.Single value = 5f;
                object obj = get("mm_per_line_segment");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("mm_per_line_segment", value);
                this.NotifyPropertyChanged("MmPerLineSegment");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Arm solution configuration"),
            System.ComponentModel.DescriptionAttribute("Steps per mm for alpha stepper"),
            System.ComponentModel.DisplayNameAttribute("Alpha Steps/mm"),
            System.ComponentModel.DefaultValue(80f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_steps_per_mm")
        ]
        public System.Single AlphaStepsPerMm
        {
            get
            {
                System.Single value = 80f;
                object obj = get("alpha_steps_per_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_steps_per_mm", value);
                this.NotifyPropertyChanged("AlphaStepsPerMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Arm solution configuration"),
            System.ComponentModel.DescriptionAttribute("Steps per mm for beta stepper"),
            System.ComponentModel.DisplayNameAttribute("Beta Steps/mm"),
            System.ComponentModel.DefaultValue(80f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_steps_per_mm")
        ]
        public System.Single BetaStepsPerMm
        {
            get
            {
                System.Single value = 80f;
                object obj = get("beta_steps_per_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_steps_per_mm", value);
                this.NotifyPropertyChanged("BetaStepsPerMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Arm solution configuration"),
            System.ComponentModel.DescriptionAttribute("Steps per mm for gamma stepper"),
            System.ComponentModel.DisplayNameAttribute("Gamma Steps/mm"),
            System.ComponentModel.DefaultValue(1600f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_steps_per_mm")
        ]
        public System.Single GammaStepsPerMm
        {
            get
            {
                System.Single value = 1600f;
                object obj = get("gamma_steps_per_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_steps_per_mm", value);
                this.NotifyPropertyChanged("GammaStepsPerMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Planner module configuration"),
            System.ComponentModel.DescriptionAttribute("DO NOT CHANGE THIS UNLESS YOU KNOW EXACTLY WHAT YOU ARE DOING"),
            System.ComponentModel.DisplayNameAttribute("Planner Queue Size"),
            System.ComponentModel.DefaultValue(32f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(false),
            SmoothieInterface.ReferenceAttribute("planner_queue_size")
        ]
        public System.Single PlannerQueueSize
        {
            get
            {
                System.Single value = 32f;
                object obj = get("planner_queue_size");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("planner_queue_size", value);
                this.NotifyPropertyChanged("PlannerQueueSize");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Planner module configuration"),
            System.ComponentModel.DescriptionAttribute("Acceleration in mm/second/second."),
            System.ComponentModel.DisplayNameAttribute("Acceleration"),
            System.ComponentModel.DefaultValue(3000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("acceleration")
        ]
        public System.Single Acceleration
        {
            get
            {
                System.Single value = 3000f;
                object obj = get("acceleration");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("acceleration", value);
                this.NotifyPropertyChanged("Acceleration");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Planner module configuration"),
            System.ComponentModel.DescriptionAttribute("Acceleration for Z only moves in mm/s^2, 0 uses acceleration which is the default. DO NOT SET ON A DELTA"),
            System.ComponentModel.DisplayNameAttribute("Z Acceleration"),
            System.ComponentModel.DefaultValue(500f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("z_acceleration")
        ]
        public System.Single ZAcceleration
        {
            get
            {
                System.Single value = 500f;
                object obj = get("z_acceleration");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("z_acceleration", value);
                this.NotifyPropertyChanged("ZAcceleration");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Planner module configuration"),
            System.ComponentModel.DescriptionAttribute("Number of times per second the speed is updated"),
            System.ComponentModel.DisplayNameAttribute("Acceleration Ticks/Second"),
            System.ComponentModel.DefaultValue(1000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("acceleration_ticks_per_second")
        ]
        public System.Single AccelerationTicksPerSecond
        {
            get
            {
                System.Single value = 1000f;
                object obj = get("acceleration_ticks_per_second");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("acceleration_ticks_per_second", value);
                this.NotifyPropertyChanged("AccelerationTicksPerSecond");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Planner module configuration"),
            System.ComponentModel.DescriptionAttribute("for Z only moves, -1 uses junction_deviation, zero disables junction_deviation on z moves DO NOT SET ON A DELTA"),
            System.ComponentModel.DisplayNameAttribute("Z Junction Deviation"),
            System.ComponentModel.DefaultValue(0.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("z_junction_deviation")
        ]
        public System.Single ZJunctionDeviation
        {
            get
            {
                System.Single value = 0.0f;
                object obj = get("z_junction_deviation");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("z_junction_deviation", value);
                this.NotifyPropertyChanged("ZJunctionDeviation");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Planner module configuration"),
            System.ComponentModel.DescriptionAttribute("sets the minimum planner speed in mm/sec"),
            System.ComponentModel.DisplayNameAttribute("Minimum Planner Speed"),
            System.ComponentModel.DefaultValue(0.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("minimum_planner_speed")
        ]
        public System.Single MinimumPlannerSpeed
        {
            get
            {
                System.Single value = 0.0f;
                object obj = get("minimum_planner_speed");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("minimum_planner_speed", value);
                this.NotifyPropertyChanged("MinimumPlannerSpeed");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module configuration"),
            System.ComponentModel.DescriptionAttribute("Duration of step pulses to stepper drivers, in microseconds"),
            System.ComponentModel.DisplayNameAttribute("Microseconds/Step Pulse"),
            System.ComponentModel.DefaultValue(1f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("microseconds_per_step_pulse")
        ]
        public System.Single MicrosecondsPerStepPulse
        {
            get
            {
                System.Single value = 1f;
                object obj = get("microseconds_per_step_pulse");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("microseconds_per_step_pulse", value);
                this.NotifyPropertyChanged("MicrosecondsPerStepPulse");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module configuration"),
            System.ComponentModel.DescriptionAttribute("Base frequency for stepping, higher gives smoother movement"),
            System.ComponentModel.DisplayNameAttribute("Base Stepping Frequency"),
            System.ComponentModel.DefaultValue(100000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("base_stepping_frequency")
        ]
        public System.Single BaseSteppingFrequency
        {
            get
            {
                System.Single value = 100000f;
                object obj = get("base_stepping_frequency");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("base_stepping_frequency", value);
                this.NotifyPropertyChanged("BaseSteppingFrequency");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Cartesian axis speed limits"),
            System.ComponentModel.DescriptionAttribute("mm/min"),
            System.ComponentModel.DisplayNameAttribute("X Axis Max Speed"),
            System.ComponentModel.DefaultValue(30000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("x_axis_max_speed")
        ]
        public System.Single XAxisMaxSpeed
        {
            get
            {
                System.Single value = 30000f;
                object obj = get("x_axis_max_speed");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("x_axis_max_speed", value);
                this.NotifyPropertyChanged("XAxisMaxSpeed");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Cartesian axis speed limits"),
            System.ComponentModel.DescriptionAttribute("mm/min"),
            System.ComponentModel.DisplayNameAttribute("Y Axis Max Speed"),
            System.ComponentModel.DefaultValue(30000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("y_axis_max_speed")
        ]
        public System.Single YAxisMaxSpeed
        {
            get
            {
                System.Single value = 30000f;
                object obj = get("y_axis_max_speed");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("y_axis_max_speed", value);
                this.NotifyPropertyChanged("YAxisMaxSpeed");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Cartesian axis speed limits"),
            System.ComponentModel.DescriptionAttribute("mm/min"),
            System.ComponentModel.DisplayNameAttribute("Z Axis Max Speed"),
            System.ComponentModel.DefaultValue(300f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("z_axis_max_speed")
        ]
        public System.Single ZAxisMaxSpeed
        {
            get
            {
                System.Single value = 300f;
                object obj = get("z_axis_max_speed");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("z_axis_max_speed", value);
                this.NotifyPropertyChanged("ZAxisMaxSpeed");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("X stepper motor current"),
            System.ComponentModel.DisplayNameAttribute("Alpha Current"),
            System.ComponentModel.DefaultValue(1.5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_current")
        ]
        public System.Single AlphaCurrent
        {
            get
            {
                System.Single value = 1.5f;
                object obj = get("alpha_current");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_current", value);
                this.NotifyPropertyChanged("AlphaCurrent");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("mm/min"),
            System.ComponentModel.DisplayNameAttribute("Alpha Max Rate"),
            System.ComponentModel.DefaultValue(30000.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_max_rate")
        ]
        public System.Single AlphaMaxRate
        {
            get
            {
                System.Single value = 30000.0f;
                object obj = get("alpha_max_rate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_max_rate", value);
                this.NotifyPropertyChanged("AlphaMaxRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Y stepper motor current"),
            System.ComponentModel.DisplayNameAttribute("Beta Current"),
            System.ComponentModel.DefaultValue(1.5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_current")
        ]
        public System.Single BetaCurrent
        {
            get
            {
                System.Single value = 1.5f;
                object obj = get("beta_current");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_current", value);
                this.NotifyPropertyChanged("BetaCurrent");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("mm/min"),
            System.ComponentModel.DisplayNameAttribute("Beta Max Rate"),
            System.ComponentModel.DefaultValue(30000.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_max_rate")
        ]
        public System.Single BetaMaxRate
        {
            get
            {
                System.Single value = 30000.0f;
                object obj = get("beta_max_rate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_max_rate", value);
                this.NotifyPropertyChanged("BetaMaxRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Z stepper motor current"),
            System.ComponentModel.DisplayNameAttribute("Gamma Current"),
            System.ComponentModel.DefaultValue(1.5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_current")
        ]
        public System.Single GammaCurrent
        {
            get
            {
                System.Single value = 1.5f;
                object obj = get("gamma_current");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_current", value);
                this.NotifyPropertyChanged("GammaCurrent");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("mm/min"),
            System.ComponentModel.DisplayNameAttribute("Gamma Max Rate"),
            System.ComponentModel.DefaultValue(300.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_max_rate")
        ]
        public System.Single GammaMaxRate
        {
            get
            {
                System.Single value = 300.0f;
                object obj = get("gamma_max_rate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_max_rate", value);
                this.NotifyPropertyChanged("GammaMaxRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Serial communications configuration"),
            System.ComponentModel.DescriptionAttribute("Baud rate for the default hardware serial port"),
            System.ComponentModel.DisplayNameAttribute("UART0 Baud Rate"),
            System.ComponentModel.DefaultValue(115200f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("uart0.baud_rate")
        ]
        public System.Single Uart0BaudRate
        {
            get
            {
                System.Single value = 115200f;
                object obj = get("uart0.baud_rate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("uart0.baud_rate", value);
                this.NotifyPropertyChanged("Uart0BaudRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("Steps per mm for extruder stepper"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Steps/mm"),
            System.ComponentModel.DefaultValue(140f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.steps_per_mm")
        ]
        public System.Single ExtruderHotendStepsPerMm
        {
            get
            {
                System.Single value = 140f;
                object obj = get("extruder.hotend.steps_per_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.steps_per_mm", value);
                this.NotifyPropertyChanged("ExtruderHotendStepsPerMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("Default rate ( mm/minute ) for moves where only the extruder moves"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Default Feed Rate"),
            System.ComponentModel.DefaultValue(600f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.default_feed_rate")
        ]
        public System.Single ExtruderHotendDefaultFeedRate
        {
            get
            {
                System.Single value = 600f;
                object obj = get("extruder.hotend.default_feed_rate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.default_feed_rate", value);
                this.NotifyPropertyChanged("ExtruderHotendDefaultFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("Acceleration for the stepper motor, as of 0.6, arbitrary ratio"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Acceleration"),
            System.ComponentModel.DefaultValue(500f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.acceleration")
        ]
        public System.Single ExtruderHotendAcceleration
        {
            get
            {
                System.Single value = 500f;
                object obj = get("extruder.hotend.acceleration");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.acceleration", value);
                this.NotifyPropertyChanged("ExtruderHotendAcceleration");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("mm/s"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Max Speed"),
            System.ComponentModel.DefaultValue(50f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.max_speed")
        ]
        public System.Single ExtruderHotendMaxSpeed
        {
            get
            {
                System.Single value = 50f;
                object obj = get("extruder.hotend.max_speed");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.max_speed", value);
                this.NotifyPropertyChanged("ExtruderHotendMaxSpeed");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("extruder offset"),
            System.ComponentModel.DescriptionAttribute("x offset from origin in mm"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend X Offset"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.x_offset")
        ]
        public System.Single ExtruderHotendXOffset
        {
            get
            {
                System.Single value = 0f;
                object obj = get("extruder.hotend.x_offset");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.x_offset", value);
                this.NotifyPropertyChanged("ExtruderHotendXOffset");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("extruder offset"),
            System.ComponentModel.DescriptionAttribute("y offset from origin in mm"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Y Offset"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.y_offset")
        ]
        public System.Single ExtruderHotendYOffset
        {
            get
            {
                System.Single value = 0f;
                object obj = get("extruder.hotend.y_offset");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.y_offset", value);
                this.NotifyPropertyChanged("ExtruderHotendYOffset");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("extruder offset"),
            System.ComponentModel.DescriptionAttribute("z offset from origin in mm"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Z Offset"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.z_offset")
        ]
        public System.Single ExtruderHotendZOffset
        {
            get
            {
                System.Single value = 0f;
                object obj = get("extruder.hotend.z_offset");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.z_offset", value);
                this.NotifyPropertyChanged("ExtruderHotendZOffset");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("firmware retract settings"),
            System.ComponentModel.DescriptionAttribute("retract length in mm"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Retract Length"),
            System.ComponentModel.DefaultValue(3f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.retract_length")
        ]
        public System.Single ExtruderHotendRetractLength
        {
            get
            {
                System.Single value = 3f;
                object obj = get("extruder.hotend.retract_length");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.retract_length", value);
                this.NotifyPropertyChanged("ExtruderHotendRetractLength");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("firmware retract settings"),
            System.ComponentModel.DescriptionAttribute("retract feedrate in mm/sec"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Retract Feed Rate"),
            System.ComponentModel.DefaultValue(45f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.retract_feedrate")
        ]
        public System.Single ExtruderHotendRetractFeedrate
        {
            get
            {
                System.Single value = 45f;
                object obj = get("extruder.hotend.retract_feedrate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.retract_feedrate", value);
                this.NotifyPropertyChanged("ExtruderHotendRetractFeedrate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("firmware retract settings"),
            System.ComponentModel.DescriptionAttribute("additional length for recover"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Retract Recover Length"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.retract_recover_length")
        ]
        public System.Single ExtruderHotendRetractRecoverLength
        {
            get
            {
                System.Single value = 0f;
                object obj = get("extruder.hotend.retract_recover_length");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.retract_recover_length", value);
                this.NotifyPropertyChanged("ExtruderHotendRetractRecoverLength");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("firmware retract settings"),
            System.ComponentModel.DescriptionAttribute("zlift on retract in mm, 0 disables"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Retract Z Lift Length"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.retract_zlift_length")
        ]
        public System.Single ExtruderHotendRetractZLiftLength
        {
            get
            {
                System.Single value = 0f;
                object obj = get("extruder.hotend.retract_zlift_length");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.retract_zlift_length", value);
                this.NotifyPropertyChanged("ExtruderHotendRetractZLiftLength");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("firmware retract settings"),
            System.ComponentModel.DescriptionAttribute("zlift feedrate in mm/min (Note mm/min NOT mm/sec)"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Retract Z Lift Feed Rate"),
            System.ComponentModel.DefaultValue(6000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.retract_zlift_feedrate")
        ]
        public System.Single ExtruderHotendRetractZLiftFeedRate
        {
            get
            {
                System.Single value = 6000f;
                object obj = get("extruder.hotend.retract_zlift_feedrate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.retract_zlift_feedrate", value);
                this.NotifyPropertyChanged("ExtruderHotendRetractZLiftFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("firmware retract settings"),
            System.ComponentModel.DescriptionAttribute("First extruder stepper motor current"),
            System.ComponentModel.DisplayNameAttribute("Delta Current"),
            System.ComponentModel.DefaultValue(1.5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("delta_current")
        ]
        public System.Single DeltaCurrent
        {
            get
            {
                System.Single value = 1.5f;
                object obj = get("delta_current");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("delta_current", value);
                this.NotifyPropertyChanged("DeltaCurrent");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Steps per mm for extruder stepper"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Steps/mm"),
            System.ComponentModel.DefaultValue(140f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.steps_per_mm")
        ]
        public System.Single ExtruderHotend2StepsPerMm
        {
            get
            {
                System.Single value = 140f;
                object obj = get("extruder.hotend2.steps_per_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.steps_per_mm", value);
                this.NotifyPropertyChanged("ExtruderHotend2StepsPerMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Default rate ( mm/minute ) for moves where only the extruder moves"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Default Feed Rate"),
            System.ComponentModel.DefaultValue(600f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.default_feed_rate")
        ]
        public System.Single ExtruderHotend2DefaultFeedRate
        {
            get
            {
                System.Single value = 600f;
                object obj = get("extruder.hotend2.default_feed_rate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.default_feed_rate", value);
                this.NotifyPropertyChanged("ExtruderHotend2DefaultFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Acceleration for the stepper motor, as of 0.6, arbitrary ratio"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Acceleration"),
            System.ComponentModel.DefaultValue(500f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.acceleration")
        ]
        public System.Single ExtruderHotend2Acceleration
        {
            get
            {
                System.Single value = 500f;
                object obj = get("extruder.hotend2.acceleration");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.acceleration", value);
                this.NotifyPropertyChanged("ExtruderHotend2Acceleration");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("mm/s"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Max Speed"),
            System.ComponentModel.DefaultValue(50f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.max_speed")
        ]
        public System.Single ExtruderHotend2MaxSpeed
        {
            get
            {
                System.Single value = 50f;
                object obj = get("extruder.hotend2.max_speed");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.max_speed", value);
                this.NotifyPropertyChanged("ExtruderHotend2MaxSpeed");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("x offset from origin in mm"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 X Offset"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.x_offset")
        ]
        public System.Single ExtruderHotend2XOffset
        {
            get
            {
                System.Single value = 0f;
                object obj = get("extruder.hotend2.x_offset");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.x_offset", value);
                this.NotifyPropertyChanged("ExtruderHotend2XOffset");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("y offset from origin in mm"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Y Offset"),
            System.ComponentModel.DefaultValue(25.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.y_offset")
        ]
        public System.Single ExtruderHotend2YOffset
        {
            get
            {
                System.Single value = 25.0f;
                object obj = get("extruder.hotend2.y_offset");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.y_offset", value);
                this.NotifyPropertyChanged("ExtruderHotend2YOffset");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("z offset from origin in mm"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Z Offset"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.z_offset")
        ]
        public System.Single ExtruderHotend2ZOffset
        {
            get
            {
                System.Single value = 0f;
                object obj = get("extruder.hotend2.z_offset");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.z_offset", value);
                this.NotifyPropertyChanged("ExtruderHotend2ZOffset");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Second extruder stepper motor current"),
            System.ComponentModel.DisplayNameAttribute("Epsilon Current"),
            System.ComponentModel.DefaultValue(1.5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("epsilon_current")
        ]
        public System.Single EpsilonCurrent
        {
            get
            {
                System.Single value = 1.5f;
                object obj = get("epsilon_current");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("epsilon_current", value);
                this.NotifyPropertyChanged("EpsilonCurrent");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Laser module configuration"),
            System.ComponentModel.DescriptionAttribute("this is the maximum duty cycle that will be applied to the laser"),
            System.ComponentModel.DisplayNameAttribute("Laser Module Max Power"),
            System.ComponentModel.DefaultValue(0.8f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("laser_module_max_power")
        ]
        public System.Single LaserModuleMaxPower
        {
            get
            {
                System.Single value = 0.8f;
                object obj = get("laser_module_max_power");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("laser_module_max_power", value);
                this.NotifyPropertyChanged("LaserModuleMaxPower");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Laser module configuration"),
            System.ComponentModel.DescriptionAttribute("this duty cycle will be used for travel moves to keep the laser active without actually burning"),
            System.ComponentModel.DisplayNameAttribute("Laser Module Tickle Power"),
            System.ComponentModel.DefaultValue(0.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("laser_module_tickle_power")
        ]
        public System.Single LaserModuleTicklePower
        {
            get
            {
                System.Single value = 0.0f;
                object obj = get("laser_module_tickle_power");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("laser_module_tickle_power", value);
                this.NotifyPropertyChanged("LaserModuleTicklePower");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Laser module configuration"),
            System.ComponentModel.DescriptionAttribute("this sets the pwm frequency as the period in microseconds"),
            System.ComponentModel.DisplayNameAttribute("Laser Module PWM Period"),
            System.ComponentModel.DefaultValue(20f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("laser_module_pwm_period")
        ]
        public System.Single LaserModulePwmPeriod
        {
            get
            {
                System.Single value = 20f;
                object obj = get("laser_module_pwm_period");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("laser_module_pwm_period", value);
                this.NotifyPropertyChanged("LaserModulePwmPeriod");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("or set the beta value (Ref: Temperature Control Hotend thermistor property)"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Beta"),
            System.ComponentModel.DefaultValue(4066f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.beta")
        ]
        public System.Single TemperatureControlHotendBeta
        {
            get
            {
                System.Single value = 4066f;
                object obj = get("temperature_control.hotend.beta");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.beta", value);
                this.NotifyPropertyChanged("TemperatureControlHotendBeta");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Set M Code"),
            System.ComponentModel.DefaultValue(104f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.set_m_code")
        ]
        public System.Single TemperatureControlHotendSetMCode
        {
            get
            {
                System.Single value = 104f;
                object obj = get("temperature_control.hotend.set_m_code");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.set_m_code", value);
                this.NotifyPropertyChanged("TemperatureControlHotendSetMCode");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Set And Wait M Code"),
            System.ComponentModel.DefaultValue(109f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.set_and_wait_m_code")
        ]
        public System.Single TemperatureControlHotendSetAndWaitMCode
        {
            get
            {
                System.Single value = 109f;
                object obj = get("temperature_control.hotend.set_and_wait_m_code");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.set_and_wait_m_code", value);
                this.NotifyPropertyChanged("TemperatureControlHotendSetAndWaitMCode");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("permanently set the PID values after an auto pid"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend P Factor"),
            System.ComponentModel.DefaultValue(13.7f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.p_factor")
        ]
        public System.Single TemperatureControlHotendPFactor
        {
            get
            {
                System.Single value = 13.7f;
                object obj = get("temperature_control.hotend.p_factor");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.p_factor", value);
                this.NotifyPropertyChanged("TemperatureControlHotendPFactor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend I Factor"),
            System.ComponentModel.DefaultValue(0.097f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.i_factor")
        ]
        public System.Single TemperatureControlHotendIFactor
        {
            get
            {
                System.Single value = 0.097f;
                object obj = get("temperature_control.hotend.i_factor");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.i_factor", value);
                this.NotifyPropertyChanged("TemperatureControlHotendIFactor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend D Factor"),
            System.ComponentModel.DefaultValue(24f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.d_factor")
        ]
        public System.Single TemperatureControlHotendDFactor
        {
            get
            {
                System.Single value = 24f;
                object obj = get("temperature_control.hotend.d_factor");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.d_factor", value);
                this.NotifyPropertyChanged("TemperatureControlHotendDFactor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("max pwm, 64 is a good value if driving a 12v resistor with 24v."),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Max PWM"),
            System.ComponentModel.DefaultValue(64f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.max_pwm")
        ]
        public System.Single TemperatureControlHotendMaxPwm
        {
            get
            {
                System.Single value = 64f;
                object obj = get("temperature_control.hotend.max_pwm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.max_pwm", value);
                this.NotifyPropertyChanged("TemperatureControlHotendMaxPwm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("or set the beta value (Ref: Temperature Control Hotend 2 thermistor property)"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Beta"),
            System.ComponentModel.DefaultValue(4066f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.beta")
        ]
        public System.Single TemperatureControlHotend2Beta
        {
            get
            {
                System.Single value = 4066f;
                object obj = get("temperature_control.hotend2.beta");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.beta", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2Beta");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Set M Code"),
            System.ComponentModel.DefaultValue(884f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.set_m_code")
        ]
        public System.Single TemperatureControlHotend2SetMCode
        {
            get
            {
                System.Single value = 884f;
                object obj = get("temperature_control.hotend2.set_m_code");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.set_m_code", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2SetMCode");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Set And Wait M Code"),
            System.ComponentModel.DefaultValue(889f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.set_and_wait_m_code")
        ]
        public System.Single TemperatureControlHotend2SetAndWaitMCode
        {
            get
            {
                System.Single value = 889f;
                object obj = get("temperature_control.hotend2.set_and_wait_m_code");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.set_and_wait_m_code", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2SetAndWaitMCode");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("permanently set the PID values after an auto pid"),
            System.ComponentModel.DisplayNameAttribute("Ttemperature Control Hotend 2 P Factor"),
            System.ComponentModel.DefaultValue(13.7f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.p_factor")
        ]
        public System.Single TtemperatureControlHotend2PFactor
        {
            get
            {
                System.Single value = 13.7f;
                object obj = get("temperature_control.hotend2.p_factor");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.p_factor", value);
                this.NotifyPropertyChanged("TtemperatureControlHotend2PFactor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 I Factor"),
            System.ComponentModel.DefaultValue(0.097f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.i_factor")
        ]
        public System.Single TemperatureControlHotend2IFactor
        {
            get
            {
                System.Single value = 0.097f;
                object obj = get("temperature_control.hotend2.i_factor");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.i_factor", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2IFactor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 D Factor"),
            System.ComponentModel.DefaultValue(24f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.d_factor")
        ]
        public System.Single TemperatureControlHotend2DFactor
        {
            get
            {
                System.Single value = 24f;
                object obj = get("temperature_control.hotend2.d_factor");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.d_factor", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2DFactor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("max pwm, 64 is a good value if driving a 12v resistor with 24v."),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Max PWM"),
            System.ComponentModel.DefaultValue(64f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.max_pwm")
        ]
        public System.Single TemperatureControlHotend2MaxPwm
        {
            get
            {
                System.Single value = 64f;
                object obj = get("temperature_control.hotend2.max_pwm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.max_pwm", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2MaxPwm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Beta"),
            System.ComponentModel.DefaultValue(3974f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.beta")
        ]
        public System.Single TemperatureControlBedBeta
        {
            get
            {
                System.Single value = 3974f;
                object obj = get("temperature_control.bed.beta");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.beta", value);
                this.NotifyPropertyChanged("TemperatureControlBedBeta");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Set M Code"),
            System.ComponentModel.DefaultValue(140f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.set_m_code")
        ]
        public System.Single TemperatureControlBedSetMCode
        {
            get
            {
                System.Single value = 140f;
                object obj = get("temperature_control.bed.set_m_code");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.set_m_code", value);
                this.NotifyPropertyChanged("TemperatureControlBedSetMCode");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Set And Wait M Code"),
            System.ComponentModel.DefaultValue(190f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.set_and_wait_m_code")
        ]
        public System.Single TemperatureControlBedSetAndWaitMCode
        {
            get
            {
                System.Single value = 190f;
                object obj = get("temperature_control.bed.set_and_wait_m_code");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.set_and_wait_m_code", value);
                this.NotifyPropertyChanged("TemperatureControlBedSetAndWaitMCode");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("set to the temperature in degrees C to use as hysteresis when using bang bang"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Hysteresis"),
            System.ComponentModel.DefaultValue(2.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.hysteresis")
        ]
        public System.Single TemperatureControlBedHysteresis
        {
            get
            {
                System.Single value = 2.0f;
                object obj = get("temperature_control.bed.hysteresis");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.hysteresis", value);
                this.NotifyPropertyChanged("TemperatureControlBedHysteresis");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute("set max pwm for the pin default is 255"),
            System.ComponentModel.DisplayNameAttribute("Switch Fan Max PWM"),
            System.ComponentModel.DefaultValue(255f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.fan.max_pwm")
        ]
        public System.Single SwitchFanMaxPwm
        {
            get
            {
                System.Single value = 255f;
                object obj = get("switch.fan.max_pwm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("switch.fan.max_pwm", value);
                this.NotifyPropertyChanged("SwitchFanMaxPwm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("automatically toggle a switch at a specified temperature."),
            System.ComponentModel.DescriptionAttribute("temperature to turn on (if rising) or off the switch"),
            System.ComponentModel.DisplayNameAttribute("Temperature Switch Hotend Threshold Temp"),
            System.ComponentModel.DefaultValue(60.0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperatureswitch.hotend.threshold_temp")
        ]
        public System.Single TemperatureSwitchHotendThresholdTemp
        {
            get
            {
                System.Single value = 60.0f;
                object obj = get("temperatureswitch.hotend.threshold_temp");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperatureswitch.hotend.threshold_temp", value);
                this.NotifyPropertyChanged("TemperatureSwitchHotendThresholdTemp");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("automatically toggle a switch at a specified temperature."),
            System.ComponentModel.DescriptionAttribute("poll heatup at 15 sec intervals"),
            System.ComponentModel.DisplayNameAttribute("Temperature Switch Hotend Heatup Poll"),
            System.ComponentModel.DefaultValue(15f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperatureswitch.hotend.heatup_poll")
        ]
        public System.Single TemperatureSwitchHotendHeatupPoll
        {
            get
            {
                System.Single value = 15f;
                object obj = get("temperatureswitch.hotend.heatup_poll");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperatureswitch.hotend.heatup_poll", value);
                this.NotifyPropertyChanged("TemperatureSwitchHotendHeatupPoll");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("automatically toggle a switch at a specified temperature."),
            System.ComponentModel.DescriptionAttribute("poll cooldown at 60 sec intervals"),
            System.ComponentModel.DisplayNameAttribute("Temperature Switch Hotend Cool Down Poll"),
            System.ComponentModel.DefaultValue(60f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperatureswitch.hotend.cooldown_poll")
        ]
        public System.Single TemperatureSwitchHotendCoolDownPoll
        {
            get
            {
                System.Single value = 60f;
                object obj = get("temperatureswitch.hotend.cooldown_poll");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperatureswitch.hotend.cooldown_poll", value);
                this.NotifyPropertyChanged("TemperatureSwitchHotendCoolDownPoll");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("this gets loaded after homing when home_to_min is set"),
            System.ComponentModel.DisplayNameAttribute("Alpha Min"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_min")
        ]
        public System.Single AlphaMin
        {
            get
            {
                System.Single value = 0f;
                object obj = get("alpha_min");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_min", value);
                this.NotifyPropertyChanged("AlphaMin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("this gets loaded after homing when home_to_max is set"),
            System.ComponentModel.DisplayNameAttribute("Alpha Max"),
            System.ComponentModel.DefaultValue(200f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_max")
        ]
        public System.Single AlphaMax
        {
            get
            {
                System.Single value = 200f;
                object obj = get("alpha_max");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_max", value);
                this.NotifyPropertyChanged("AlphaMax");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Beta Min"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_min")
        ]
        public System.Single BetaMin
        {
            get
            {
                System.Single value = 0f;
                object obj = get("beta_min");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_min", value);
                this.NotifyPropertyChanged("BetaMin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Beta Max"),
            System.ComponentModel.DefaultValue(200f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_max")
        ]
        public System.Single BetaMax
        {
            get
            {
                System.Single value = 200f;
                object obj = get("beta_max");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_max", value);
                this.NotifyPropertyChanged("BetaMax");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Gamma Min"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_min")
        ]
        public System.Single GammaMin
        {
            get
            {
                System.Single value = 0f;
                object obj = get("gamma_min");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_min", value);
                this.NotifyPropertyChanged("GammaMin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Gamma Max"),
            System.ComponentModel.DefaultValue(200f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_max")
        ]
        public System.Single GammaMax
        {
            get
            {
                System.Single value = 200f;
                object obj = get("gamma_max");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_max", value);
                this.NotifyPropertyChanged("GammaMax");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("feed rates in mm/second"),
            System.ComponentModel.DisplayNameAttribute("Alpha Fast Homing Rate mm/s"),
            System.ComponentModel.DefaultValue(50f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_fast_homing_rate_mm_s")
        ]
        public System.Single AlphaFastHomingRateMmS
        {
            get
            {
                System.Single value = 50f;
                object obj = get("alpha_fast_homing_rate_mm_s");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_fast_homing_rate_mm_s", value);
                this.NotifyPropertyChanged("AlphaFastHomingRateMmS");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("feed rates in mm/second"),
            System.ComponentModel.DisplayNameAttribute("Beta Fast Homing Rate mm/s"),
            System.ComponentModel.DefaultValue(50f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_fast_homing_rate_mm_s")
        ]
        public System.Single BetaFastHomingRateMmS
        {
            get
            {
                System.Single value = 50f;
                object obj = get("beta_fast_homing_rate_mm_s");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_fast_homing_rate_mm_s", value);
                this.NotifyPropertyChanged("BetaFastHomingRateMmS");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("feed rates in mm/second"),
            System.ComponentModel.DisplayNameAttribute("Gamma Fast Homing Rate mm/s"),
            System.ComponentModel.DefaultValue(4f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_fast_homing_rate_mm_s")
        ]
        public System.Single GammaFastHomingRateMmS
        {
            get
            {
                System.Single value = 4f;
                object obj = get("gamma_fast_homing_rate_mm_s");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_fast_homing_rate_mm_s", value);
                this.NotifyPropertyChanged("GammaFastHomingRateMmS");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("feedrates in mm/second"),
            System.ComponentModel.DisplayNameAttribute("Alpha Slow Homing Rate mm/s"),
            System.ComponentModel.DefaultValue(25f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_slow_homing_rate_mm_s")
        ]
        public System.Single AlphaSlowHomingRateMmS
        {
            get
            {
                System.Single value = 25f;
                object obj = get("alpha_slow_homing_rate_mm_s");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_slow_homing_rate_mm_s", value);
                this.NotifyPropertyChanged("AlphaSlowHomingRateMmS");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("feed rates in mm/second"),
            System.ComponentModel.DisplayNameAttribute("Beta Slow Homing Rate mm/s"),
            System.ComponentModel.DefaultValue(25f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_slow_homing_rate_mm_s")
        ]
        public System.Single BetaSlowHomingRateMmS
        {
            get
            {
                System.Single value = 25f;
                object obj = get("beta_slow_homing_rate_mm_s");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_slow_homing_rate_mm_s", value);
                this.NotifyPropertyChanged("BetaSlowHomingRateMmS");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("distance in mm"),
            System.ComponentModel.DisplayNameAttribute("Alpha Homing Retract mm"),
            System.ComponentModel.DefaultValue(5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_homing_retract_mm")
        ]
        public System.Single AlphaHomingRetractMm
        {
            get
            {
                System.Single value = 5f;
                object obj = get("alpha_homing_retract_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("alpha_homing_retract_mm", value);
                this.NotifyPropertyChanged("AlphaHomingRetractMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("distance in mm"),
            System.ComponentModel.DisplayNameAttribute("Beta Homing Retract mm"),
            System.ComponentModel.DefaultValue(5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_homing_retract_mm")
        ]
        public System.Single BetaHomingRetractMm
        {
            get
            {
                System.Single value = 5f;
                object obj = get("beta_homing_retract_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("beta_homing_retract_mm", value);
                this.NotifyPropertyChanged("BetaHomingRetractMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("distance in mm"),
            System.ComponentModel.DisplayNameAttribute("Gamma Homing Retract mm"),
            System.ComponentModel.DefaultValue(1f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_homing_retract_mm")
        ]
        public System.Single GammaHomingRetractMm
        {
            get
            {
                System.Single value = 1f;
                object obj = get("gamma_homing_retract_mm");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_homing_retract_mm", value);
                this.NotifyPropertyChanged("GammaHomingRetractMm");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("uncomment if you get noise on your endstops, default is 100"),
            System.ComponentModel.DisplayNameAttribute("End Stop Debounce Count"),
            System.ComponentModel.DefaultValue(100f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("endstop_debounce_count")
        ]
        public System.Single EndStopDebounceCount
        {
            get
            {
                System.Single value = 100f;
                object obj = get("endstop_debounce_count");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("endstop_debounce_count", value);
                this.NotifyPropertyChanged("EndStopDebounceCount");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("optional Z probe"),
            System.ComponentModel.DescriptionAttribute("mm/sec probe feed rate"),
            System.ComponentModel.DisplayNameAttribute("Z Probe Slow Feed Rate"),
            System.ComponentModel.DefaultValue(5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("zprobe.slow_feedrate")
        ]
        public System.Single ZProbeSlowFeedRate
        {
            get
            {
                System.Single value = 5f;
                object obj = get("zprobe.slow_feedrate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("zprobe.slow_feedrate", value);
                this.NotifyPropertyChanged("ZProbeSlowFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("optional Z probe"),
            System.ComponentModel.DescriptionAttribute("set if noisy"),
            System.ComponentModel.DisplayNameAttribute("Z Probe Debounce Count"),
            System.ComponentModel.DefaultValue(100f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("zprobe.debounce_count")
        ]
        public System.Single ZProbeDebounceCount
        {
            get
            {
                System.Single value = 100f;
                object obj = get("zprobe.debounce_count");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("zprobe.debounce_count", value);
                this.NotifyPropertyChanged("ZProbeDebounceCount");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("optional Z probe"),
            System.ComponentModel.DescriptionAttribute("move feedrate mm/sec"),
            System.ComponentModel.DisplayNameAttribute("Z Probe Fast Feed Rate"),
            System.ComponentModel.DefaultValue(100f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("zprobe.fast_feedrate")
        ]
        public System.Single ZProbeFastFeedRate
        {
            get
            {
                System.Single value = 100f;
                object obj = get("zprobe.fast_feedrate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("zprobe.fast_feedrate", value);
                this.NotifyPropertyChanged("ZProbeFastFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("optional Z probe"),
            System.ComponentModel.DescriptionAttribute("how much above bed to start probe"),
            System.ComponentModel.DisplayNameAttribute("Z Probe Probe Height"),
            System.ComponentModel.DefaultValue(5f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("zprobe.probe_height")
        ]
        public System.Single ZProbeProbeHeight
        {
            get
            {
                System.Single value = 5f;
                object obj = get("zprobe.probe_height");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("zprobe.probe_height", value);
                this.NotifyPropertyChanged("ZProbeProbeHeight");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("the probe tolerance in mm, anything less that this will be ignored, default is 0.03mm"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Tolerance"),
            System.ComponentModel.DefaultValue(0.03f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.tolerance")
        ]
        public System.Single LevelingStrategyThreePointLevelingTolerance
        {
            get
            {
                System.Single value = 0.03f;
                object obj = get("leveling-strategy.three-point-leveling.tolerance");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.tolerance", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingTolerance");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("spi channel to use  ; GLCD EXP1 Pins 3,5 (MOSI, SCLK)"),
            System.ComponentModel.DisplayNameAttribute("Panel SPI Channel"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.spi_channel")
        ]
        public System.Single PanelSpiChannel
        {
            get
            {
                System.Single value = 0f;
                object obj = get("panel.spi_channel");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("panel.spi_channel", value);
                this.NotifyPropertyChanged("PanelSpiChannel");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("some panels will need 1 here"),
            System.ComponentModel.DisplayNameAttribute("Panel Menu Offset"),
            System.ComponentModel.DefaultValue(0f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.menu_offset")
        ]
        public System.Single PanelMenuOffset
        {
            get
            {
                System.Single value = 0f;
                object obj = get("panel.menu_offset");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("panel.menu_offset", value);
                this.NotifyPropertyChanged("PanelMenuOffset");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("x jogging feedrate in mm/min"),
            System.ComponentModel.DisplayNameAttribute("Panel Alpha Jog Feed Rate"),
            System.ComponentModel.DefaultValue(6000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.alpha_jog_feedrate")
        ]
        public System.Single PanelAlphaJogFeedRate
        {
            get
            {
                System.Single value = 6000f;
                object obj = get("panel.alpha_jog_feedrate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("panel.alpha_jog_feedrate", value);
                this.NotifyPropertyChanged("PanelAlphaJogFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("y jogging feedrate in mm/min"),
            System.ComponentModel.DisplayNameAttribute("Panel Beta Jog Feed Rate"),
            System.ComponentModel.DefaultValue(6000f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.beta_jog_feedrate")
        ]
        public System.Single PanelBetaJogFeedRate
        {
            get
            {
                System.Single value = 6000f;
                object obj = get("panel.beta_jog_feedrate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("panel.beta_jog_feedrate", value);
                this.NotifyPropertyChanged("PanelBetaJogFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("z jogging feedrate in mm/min"),
            System.ComponentModel.DisplayNameAttribute("Panel Gamma Jog Feed Rate"),
            System.ComponentModel.DefaultValue(200f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.gamma_jog_feedrate")
        ]
        public System.Single PanelGammaJogFeedRate
        {
            get
            {
                System.Single value = 200f;
                object obj = get("panel.gamma_jog_feedrate");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("panel.gamma_jog_feedrate", value);
                this.NotifyPropertyChanged("PanelGammaJogFeedRate");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("temp to set hotend when preheat is selected"),
            System.ComponentModel.DisplayNameAttribute("Panel Hotend Temperature"),
            System.ComponentModel.DefaultValue(185f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.hotend_temperature")
        ]
        public System.Single PanelHotendTemperature
        {
            get
            {
                System.Single value = 185f;
                object obj = get("panel.hotend_temperature");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("panel.hotend_temperature", value);
                this.NotifyPropertyChanged("PanelHotendTemperature");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("temp to set bed when preheat is selected"),
            System.ComponentModel.DisplayNameAttribute("Panel Bed Temperature"),
            System.ComponentModel.DefaultValue(60f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.bed_temperature")
        ]
        public System.Single PanelBedTemperature
        {
            get
            {
                System.Single value = 60f;
                object obj = get("panel.bed_temperature");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("panel.bed_temperature", value);
                this.NotifyPropertyChanged("PanelBedTemperature");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("feedrates in mm/second"),
            System.ComponentModel.DisplayNameAttribute("Gamma Slow Homing Rate mm/s"),
            System.ComponentModel.DefaultValue(2f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_slow_homing_rate_mm_s")
        ]
        public System.Single GammaSlowHomingRateMmS
        {
            get
            {
                System.Single value = 2f;
                object obj = get("gamma_slow_homing_rate_mm_s");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("gamma_slow_homing_rate_mm_s", value);
                this.NotifyPropertyChanged("GammaSlowHomingRateMmS");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for alpha stepper step signal"),
            System.ComponentModel.DisplayNameAttribute("Alpha Step Pin"),
            System.ComponentModel.DefaultValue("2.0"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_step_pin")
        ]
        public System.String AlphaStepPin
        {
            get
            {
                System.String value = "2.0";
                object obj = get("alpha_step_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("alpha_step_pin", value);
                this.NotifyPropertyChanged("AlphaStepPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for alpha stepper direction"),
            System.ComponentModel.DisplayNameAttribute("Alpha Dir Pin"),
            System.ComponentModel.DefaultValue("0.5"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_dir_pin")
        ]
        public System.String AlphaDirPin
        {
            get
            {
                System.String value = "0.5";
                object obj = get("alpha_dir_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("alpha_dir_pin", value);
                this.NotifyPropertyChanged("AlphaDirPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for alpha enable pin"),
            System.ComponentModel.DisplayNameAttribute("Alpha Enable Pin"),
            System.ComponentModel.DefaultValue("0.4"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_en_pin")
        ]
        public System.String AlphaEnPin
        {
            get
            {
                System.String value = "0.4";
                object obj = get("alpha_en_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("alpha_en_pin", value);
                this.NotifyPropertyChanged("AlphaEnPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for beta stepper step signal"),
            System.ComponentModel.DisplayNameAttribute("Beta Step Pin"),
            System.ComponentModel.DefaultValue("2.1"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_step_pin")
        ]
        public System.String BetaStepPin
        {
            get
            {
                System.String value = "2.1";
                object obj = get("beta_step_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("beta_step_pin", value);
                this.NotifyPropertyChanged("BetaStepPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for beta stepper direction"),
            System.ComponentModel.DisplayNameAttribute("Beta Dir Pin"),
            System.ComponentModel.DefaultValue("0.11"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_dir_pin")
        ]
        public System.String BetaDirPin
        {
            get
            {
                System.String value = "0.11";
                object obj = get("beta_dir_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("beta_dir_pin", value);
                this.NotifyPropertyChanged("BetaDirPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for beta enable"),
            System.ComponentModel.DisplayNameAttribute("Beta Enable Pin"),
            System.ComponentModel.DefaultValue("0.10"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_en_pin")
        ]
        public System.String BetaEnPin
        {
            get
            {
                System.String value = "0.10";
                object obj = get("beta_en_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("beta_en_pin", value);
                this.NotifyPropertyChanged("BetaEnPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for gamma stepper step signal"),
            System.ComponentModel.DisplayNameAttribute("Gamma Step Pin"),
            System.ComponentModel.DefaultValue("2.2"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_step_pin")
        ]
        public System.String GammaStepPin
        {
            get
            {
                System.String value = "2.2";
                object obj = get("gamma_step_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("gamma_step_pin", value);
                this.NotifyPropertyChanged("GammaStepPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for gamma stepper direction"),
            System.ComponentModel.DisplayNameAttribute("Gamma Dir Pin"),
            System.ComponentModel.DefaultValue("0.20"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_dir_pin")
        ]
        public System.String GammaDirPin
        {
            get
            {
                System.String value = "0.20";
                object obj = get("gamma_dir_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("gamma_dir_pin", value);
                this.NotifyPropertyChanged("GammaDirPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Stepper module pins"),
            System.ComponentModel.DescriptionAttribute("Pin for gamma enable"),
            System.ComponentModel.DisplayNameAttribute("Gamma Enable Pin"),
            System.ComponentModel.DefaultValue("0.19"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_en_pin")
        ]
        public System.String GammaEnPin
        {
            get
            {
                System.String value = "0.19";
                object obj = get("gamma_en_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("gamma_en_pin", value);
                this.NotifyPropertyChanged("GammaEnPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("User Interface Configuration"),
            System.ComponentModel.DescriptionAttribute("pause button pin. default is P2.12"),
            System.ComponentModel.DisplayNameAttribute("Pause Button Pin"),
            System.ComponentModel.DefaultValue("2.12"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("pause_button_pin")
        ]
        public System.String PauseButtonPin
        {
            get
            {
                System.String value = "2.12";
                object obj = get("pause_button_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("pause_button_pin", value);
                this.NotifyPropertyChanged("PauseButtonPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("User Interface Configuration"),
            System.ComponentModel.DescriptionAttribute("kill button pin. default is same as pause button 2.12 (2.11 is another good choice)"),
            System.ComponentModel.DisplayNameAttribute("Kill Button Pin"),
            System.ComponentModel.DefaultValue("2.12"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("kill_button_pin")
        ]
        public System.String KillButtonPin
        {
            get
            {
                System.String value = "2.12";
                object obj = get("kill_button_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("kill_button_pin", value);
                this.NotifyPropertyChanged("KillButtonPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for extruder step signal"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Step Pin"),
            System.ComponentModel.DefaultValue("2.3"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.step_pin")
        ]
        public System.String ExtruderHotendStepPin
        {
            get
            {
                System.String value = "2.3";
                object obj = get("extruder.hotend.step_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.step_pin", value);
                this.NotifyPropertyChanged("ExtruderHotendStepPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for extruder dir signal"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Dir Pin"),
            System.ComponentModel.DefaultValue("0.22"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.dir_pin")
        ]
        public System.String ExtruderHotendDirPin
        {
            get
            {
                System.String value = "0.22";
                object obj = get("extruder.hotend.dir_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.dir_pin", value);
                this.NotifyPropertyChanged("ExtruderHotendDirPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for extruder enable signal"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Enable Pin"),
            System.ComponentModel.DefaultValue("0.21"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.en_pin")
        ]
        public System.String ExtruderHotendEnPin
        {
            get
            {
                System.String value = "0.21";
                object obj = get("extruder.hotend.en_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.en_pin", value);
                this.NotifyPropertyChanged("ExtruderHotendEnPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for extruder step signal"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Step Pin"),
            System.ComponentModel.DefaultValue("2.8"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.step_pin")
        ]
        public System.String ExtruderHotend2StepPin
        {
            get
            {
                System.String value = "2.8";
                object obj = get("extruder.hotend2.step_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.step_pin", value);
                this.NotifyPropertyChanged("ExtruderHotend2StepPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for extruder dir signal"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Dir Pin"),
            System.ComponentModel.DefaultValue("2.13"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.dir_pin")
        ]
        public System.String ExtruderHotend2DirPin
        {
            get
            {
                System.String value = "2.13";
                object obj = get("extruder.hotend2.dir_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.dir_pin", value);
                this.NotifyPropertyChanged("ExtruderHotend2DirPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for extruder enable signal"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Enable Pin"),
            System.ComponentModel.DefaultValue("4.29"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.en_pin")
        ]
        public System.String ExtruderHotend2EnPin
        {
            get
            {
                System.String value = "4.29";
                object obj = get("extruder.hotend2.en_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.en_pin", value);
                this.NotifyPropertyChanged("ExtruderHotend2EnPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Laser module configuration"),
            System.ComponentModel.DescriptionAttribute("this pin will be PWMed to control the laser. Only P2.0 - P2.5, P1.18, P1.20, P1.21, P1.23, P1.24, P1.26, P3.25, P3.26 can be used since laser requires hardware PWM"),
            System.ComponentModel.DisplayNameAttribute("Laser Module Pin"),
            System.ComponentModel.DefaultValue("2.5"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("laser_module_pin")
        ]
        public System.String LaserModulePin
        {
            get
            {
                System.String value = "2.5";
                object obj = get("laser_module_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("laser_module_pin", value);
                this.NotifyPropertyChanged("LaserModulePin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for the thermistor to read"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Thermistor Pin"),
            System.ComponentModel.DefaultValue(0.23f),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.thermistor_pin")
        ]
        public System.Single TemperatureControlHotendThermistorPin
        {
            get
            {
                System.Single value = 0.23f;
                object obj = get("temperature_control.hotend.thermistor_pin");
                if (obj is System.Single)
                    value = (System.Single)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.thermistor_pin", value);
                this.NotifyPropertyChanged("TemperatureControlHotendThermistorPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("Pin that controls the heater, set to nc if a readonly thermistor is being defined"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Heater Pin"),
            System.ComponentModel.DefaultValue("2.7"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.heater_pin")
        ]
        public System.String TemperatureControlHotendHeaterPin
        {
            get
            {
                System.String value = "2.7";
                object obj = get("temperature_control.hotend.heater_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.heater_pin", value);
                this.NotifyPropertyChanged("TemperatureControlHotendHeaterPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("Pin for the thermistor to read"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Thermistor Pin"),
            System.ComponentModel.DefaultValue("0.25"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.thermistor_pin")
        ]
        public System.String TemperatureControlHotend2ThermistorPin
        {
            get
            {
                System.String value = "0.25";
                object obj = get("temperature_control.hotend2.thermistor_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.thermistor_pin", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2ThermistorPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("Pin that controls the heater"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Heater Pin"),
            System.ComponentModel.DefaultValue("1.23"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.heater_pin")
        ]
        public System.String TemperatureControlHotend2HeaterPin
        {
            get
            {
                System.String value = "1.23";
                object obj = get("temperature_control.hotend2.heater_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.heater_pin", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2HeaterPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Thermistor Pin"),
            System.ComponentModel.DefaultValue("0.24"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.thermistor_pin")
        ]
        public System.String TemperatureControlBedThermistorPin
        {
            get
            {
                System.String value = "0.24";
                object obj = get("temperature_control.bed.thermistor_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.thermistor_pin", value);
                this.NotifyPropertyChanged("TemperatureControlBedThermistorPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Heater Pin"),
            System.ComponentModel.DefaultValue("2.5"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.heater_pin")
        ]
        public System.String TemperatureControlBedHeaterPin
        {
            get
            {
                System.String value = "2.5";
                object obj = get("temperature_control.bed.heater_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.heater_pin", value);
                this.NotifyPropertyChanged("TemperatureControlBedHeaterPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Fan Output Pin"),
            System.ComponentModel.DefaultValue("2.6"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.fan.output_pin")
        ]
        public System.String SwitchFanOutputPin
        {
            get
            {
                System.String value = "2.6";
                object obj = get("switch.fan.output_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.fan.output_pin", value);
                this.NotifyPropertyChanged("SwitchFanOutputPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Misc Output Pin"),
            System.ComponentModel.DefaultValue("2.4"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.misc.output_pin")
        ]
        public System.String SwitchMiscOutputPin
        {
            get
            {
                System.String value = "2.4";
                object obj = get("switch.misc.output_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.misc.output_pin", value);
                this.NotifyPropertyChanged("SwitchMiscOutputPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("the probe offsets from nozzle, must be x,y,z, default is no offset"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Probe Offsets"),
            System.ComponentModel.DefaultValue("0,0,0"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.probe_offsets")
        ]
        public System.String LevelingStrategyThreePointLevelingProbeOffsets
        {
            get
            {
                System.String value = "0,0,0";
                object obj = get("leveling-strategy.three-point-leveling.probe_offsets");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.probe_offsets", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingProbeOffsets");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("spi chip select     ; GLCD EXP1 Pin 4"),
            System.ComponentModel.DisplayNameAttribute("Panel SPI CS Pin"),
            System.ComponentModel.DefaultValue("0.16"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.spi_cs_pin")
        ]
        public System.String PanelSpiCsPin
        {
            get
            {
                System.String value = "0.16";
                object obj = get("panel.spi_cs_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.spi_cs_pin", value);
                this.NotifyPropertyChanged("PanelSpiCsPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("pin for buzzer      ; GLCD EXP1 Pin 1"),
            System.ComponentModel.DisplayNameAttribute("Panel Buzz Pin"),
            System.ComponentModel.DefaultValue("1.31"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.buzz_pin")
        ]
        public System.String PanelBuzzPin
        {
            get
            {
                System.String value = "1.31";
                object obj = get("panel.buzz_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.buzz_pin", value);
                this.NotifyPropertyChanged("PanelBuzzPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Serial communications configuration"),
            System.ComponentModel.DescriptionAttribute("This enables a second usb serial port (to have both pronterface and a terminal connected)"),
            System.ComponentModel.DisplayNameAttribute("Second USB Serial Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("second_usb_serial_enable")
        ]
        public System.Boolean SecondUsbSerialEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("second_usb_serial_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("second_usb_serial_enable", value);
                this.NotifyPropertyChanged("SecondUsbSerialEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("User Interface Configuration"),
            System.ComponentModel.DescriptionAttribute("disable using leds after config loaded"),
            System.ComponentModel.DisplayNameAttribute("LEDs Disable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leds_disable")
        ]
        public System.Boolean LedsDisable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("leds_disable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("leds_disable", value);
                this.NotifyPropertyChanged("LedsDisable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("User Interface Configuration"),
            System.ComponentModel.DescriptionAttribute("disable the play led"),
            System.ComponentModel.DisplayNameAttribute("Play LED Disable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("play_led_disable")
        ]
        public System.Boolean PlayLedDisable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("play_led_disable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("play_led_disable", value);
                this.NotifyPropertyChanged("PlayLedDisable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("User Interface Configuration"),
            System.ComponentModel.DescriptionAttribute("Pause button enable"),
            System.ComponentModel.DisplayNameAttribute("Pause Button Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("pause_button_enable")
        ]
        public System.Boolean PauseButtonEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("pause_button_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("pause_button_enable", value);
                this.NotifyPropertyChanged("PauseButtonEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("User Interface Configuration"),
            System.ComponentModel.DescriptionAttribute("set to true to enable a kill button"),
            System.ComponentModel.DisplayNameAttribute("Kill Button Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("kill_button_enable")
        ]
        public System.Boolean KillButtonEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("kill_button_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("kill_button_enable", value);
                this.NotifyPropertyChanged("KillButtonEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("User Interface Configuration"),
            System.ComponentModel.DescriptionAttribute("disable the MSD (USB SDCARD) when set to true (needs special binary)"),
            System.ComponentModel.DisplayNameAttribute("MSD Disable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(false),
            SmoothieInterface.ReferenceAttribute("msd_disable")
        ]
        public System.Boolean MsdDisable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("msd_disable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("msd_disable", value);
                this.NotifyPropertyChanged("MsdDisable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder module configuration"),
            System.ComponentModel.DescriptionAttribute("Whether to activate the extruder module at all. All configuration is ignored if false"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend.enable")
        ]
        public System.Boolean ExtruderHotendEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("extruder.hotend.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("extruder.hotend.enable", value);
                this.NotifyPropertyChanged("ExtruderHotendEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Extruder 2 module configuration"),
            System.ComponentModel.DescriptionAttribute("Whether to activate the extruder module at all. All configuration is ignored if false"),
            System.ComponentModel.DisplayNameAttribute("Extruder Hotend 2 Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("extruder.hotend2.enable")
        ]
        public System.Boolean ExtruderHotend2Enable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("extruder.hotend2.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("extruder.hotend2.enable", value);
                this.NotifyPropertyChanged("ExtruderHotend2Enable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Laser module configuration"),
            System.ComponentModel.DescriptionAttribute("Whether to activate the laser module at all. All configuration is ignored if false."),
            System.ComponentModel.DisplayNameAttribute("Laser Module Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("laser_module_enable")
        ]
        public System.Boolean LaserModuleEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("laser_module_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("laser_module_enable", value);
                this.NotifyPropertyChanged("LaserModuleEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.enable")
        ]
        public System.Boolean TemperatureControlBedEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("temperature_control.bed.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.enable", value);
                this.NotifyPropertyChanged("TemperatureControlBedEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("set to true to use bang bang control rather than PID"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Bang Bang"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.bang_bang")
        ]
        public System.Boolean TemperatureControlBedBangBang
        {
            get
            {
                System.Boolean value = false;
                object obj = get("temperature_control.bed.bang_bang");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.bang_bang", value);
                this.NotifyPropertyChanged("TemperatureControlBedBangBang");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Fan Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.fan.enable")
        ]
        public System.Boolean SwitchFanEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("switch.fan.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("switch.fan.enable", value);
                this.NotifyPropertyChanged("SwitchFanEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Misc Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.misc.enable")
        ]
        public System.Boolean SwitchMiscEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("switch.misc.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("switch.misc.enable", value);
                this.NotifyPropertyChanged("SwitchMiscEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("automatically toggle a switch at a specified temperature."),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Switch Hotend Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperatureswitch.hotend.enable")
        ]
        public System.Boolean TemperatureSwitchHotendEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("temperatureswitch.hotend.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("temperatureswitch.hotend.enable", value);
                this.NotifyPropertyChanged("TemperatureSwitchHotendEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for spindle control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Spindle Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.spindle.enable")
        ]
        public System.Boolean SwitchSpindleEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("switch.spindle.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("switch.spindle.enable", value);
                this.NotifyPropertyChanged("SwitchSpindleEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("the endstop module is enabled by default and can be disabled here"),
            System.ComponentModel.DisplayNameAttribute("End Stops Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("endstops_enable")
        ]
        public System.Boolean EndStopsEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("endstops_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("endstops_enable", value);
                this.NotifyPropertyChanged("EndStopsEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("set to true if homing on a hbit or corexy"),
            System.ComponentModel.DisplayNameAttribute("Corexy Homing"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("corexy_homing")
        ]
        public System.Boolean CorexyHoming
        {
            get
            {
                System.Boolean value = false;
                object obj = get("corexy_homing");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("corexy_homing", value);
                this.NotifyPropertyChanged("CorexyHoming");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("set to true to enable X min and max limit switches"),
            System.ComponentModel.DisplayNameAttribute("Alpha Limit Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_limit_enable")
        ]
        public System.Boolean AlphaLimitEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("alpha_limit_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("alpha_limit_enable", value);
                this.NotifyPropertyChanged("AlphaLimitEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("set to true to enable Y min and max limit switches"),
            System.ComponentModel.DisplayNameAttribute("Beta Limit Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_limit_enable")
        ]
        public System.Boolean BetaLimitEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("beta_limit_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("beta_limit_enable", value);
                this.NotifyPropertyChanged("BetaLimitEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("set to true to enable Z min and max limit switches"),
            System.ComponentModel.DisplayNameAttribute("Gamma Limit Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_limit_enable")
        ]
        public System.Boolean GammaLimitEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("gamma_limit_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("gamma_limit_enable", value);
                this.NotifyPropertyChanged("GammaLimitEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("optional Z probe"),
            System.ComponentModel.DescriptionAttribute("set to true to enable a zprobe"),
            System.ComponentModel.DisplayNameAttribute("Z Probe Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("zprobe.enable")
        ]
        public System.Boolean ZProbeEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("zprobe.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("zprobe.enable", value);
                this.NotifyPropertyChanged("ZProbeEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("a leveling strategy that probes three points to define a plane and keeps the Z parallel to that plane"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.enable")
        ]
        public System.Boolean LevelingStrategyThreePointLevelingEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("leveling-strategy.three-point-leveling.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.enable", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("home the XY axis before probing"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Home First"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.home_first")
        ]
        public System.Boolean LevelingStrategyThreePointLevelingHomeFirst
        {
            get
            {
                System.Boolean value = true;
                object obj = get("leveling-strategy.three-point-leveling.home_first");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.home_first", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingHomeFirst");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("set to true to allow the bed plane to be saved with M500 default is false"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Save Plane"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.save_plane")
        ]
        public System.Boolean LevelingStrategyThreePointLevelingSavePlane
        {
            get
            {
                System.Boolean value = false;
                object obj = get("leveling-strategy.three-point-leveling.save_plane");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.save_plane", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingSavePlane");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Panel"),
            System.ComponentModel.DescriptionAttribute("set to true to enable the panel code"),
            System.ComponentModel.DisplayNameAttribute("Panel Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.enable")
        ]
        public System.Boolean PanelEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("panel.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("panel.enable", value);
                this.NotifyPropertyChanged("PanelEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Only needed on a smoothieboard"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Current Control Module Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("currentcontrol_module_enable")
        ]
        public System.Boolean CurrentControlModuleEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("currentcontrol_module_enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("currentcontrol_module_enable", value);
                this.NotifyPropertyChanged("CurrentControlModuleEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Only needed on a smoothieboard"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Return Error On Unhandled G-Code"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("return_error_on_unhandled_gcode")
        ]
        public System.Boolean ReturnErrorOnUnhandledGCode
        {
            get
            {
                System.Boolean value = false;
                object obj = get("return_error_on_unhandled_gcode");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("return_error_on_unhandled_gcode", value);
                this.NotifyPropertyChanged("ReturnErrorOnUnhandledGCode");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("network settings"),
            System.ComponentModel.DescriptionAttribute("enable the ethernet network services"),
            System.ComponentModel.DisplayNameAttribute("Network Enable"),
            System.ComponentModel.DefaultValue(false),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("network.enable")
        ]
        public System.Boolean NetworkEnable
        {
            get
            {
                System.Boolean value = false;
                object obj = get("network.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("network.enable", value);
                this.NotifyPropertyChanged("NetworkEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("network settings"),
            System.ComponentModel.DescriptionAttribute("enable the webserver"),
            System.ComponentModel.DisplayNameAttribute("Network Web Server Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("network.webserver.enable")
        ]
        public System.Boolean NetworkWebServerEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("network.webserver.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("network.webserver.enable", value);
                this.NotifyPropertyChanged("NetworkWebServerEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("network settings"),
            System.ComponentModel.DescriptionAttribute("enable the telnet server"),
            System.ComponentModel.DisplayNameAttribute("Network Telnet Enable"),
            System.ComponentModel.DefaultValue(true),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("network.telnet.enable")
        ]
        public System.Boolean NetworkTelnetEnable
        {
            get
            {
                System.Boolean value = true;
                object obj = get("network.telnet.enable");
                if (obj is System.Boolean)
                    value = (System.Boolean)obj;
                return value;
            }
            set
            {
                set("network.telnet.enable", value);
                this.NotifyPropertyChanged("NetworkTelnetEnable");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("see http://smoothieware.org/temperaturecontrol#toc5"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Thermistor"),
            System.ComponentModel.DefaultValue("EPCOS100K"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.thermistor")
        ]
        public System.String TemperatureControlHotendThermistor
        {
            get
            {
                System.String value = "EPCOS100K";
                object obj = get("temperature_control.hotend.thermistor");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.thermistor", value);
                this.NotifyPropertyChanged("TemperatureControlHotendThermistor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend Designator"),
            System.ComponentModel.DefaultValue("T"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend.designator")
        ]
        public System.String TemperatureControlHotendDesignator
        {
            get
            {
                System.String value = "T";
                object obj = get("temperature_control.hotend.designator");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend.designator", value);
                this.NotifyPropertyChanged("TemperatureControlHotendDesignator");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("see http://smoothieware.org/temperaturecontrol#toc5"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Thermistor"),
            System.ComponentModel.DefaultValue("EPCOS100K"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.thermistor")
        ]
        public System.String TemperatureControlHotend2Thermistor
        {
            get
            {
                System.String value = "EPCOS100K";
                object obj = get("temperature_control.hotend2.thermistor");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.thermistor", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2Thermistor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Hotend 2 Designator"),
            System.ComponentModel.DefaultValue("T1"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.hotend2.designator")
        ]
        public System.String TemperatureControlHotend2Designator
        {
            get
            {
                System.String value = "T1";
                object obj = get("temperature_control.hotend2.designator");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.hotend2.designator", value);
                this.NotifyPropertyChanged("TemperatureControlHotend2Designator");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute("see http://smoothieware.org/temperaturecontrol#toc5 or set the beta value"),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Thermistor"),
            System.ComponentModel.DefaultValue("Honeywell100K"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.thermistor")
        ]
        public System.String TemperatureControlBedThermistor
        {
            get
            {
                System.String value = "Honeywell100K";
                object obj = get("temperature_control.bed.thermistor");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.thermistor", value);
                this.NotifyPropertyChanged("TemperatureControlBedThermistor");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Hotend2 temperature control configuration"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Temperature Control Bed Designator"),
            System.ComponentModel.DefaultValue("B"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperature_control.bed.designator")
        ]
        public System.String TemperatureControlBedDesignator
        {
            get
            {
                System.String value = "B";
                object obj = get("temperature_control.bed.designator");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperature_control.bed.designator", value);
                this.NotifyPropertyChanged("TemperatureControlBedDesignator");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Fan Input On Command"),
            System.ComponentModel.DefaultValue("M106"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.fan.input_on_command")
        ]
        public System.String SwitchFanInputOnCommand
        {
            get
            {
                System.String value = "M106";
                object obj = get("switch.fan.input_on_command");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.fan.input_on_command", value);
                this.NotifyPropertyChanged("SwitchFanInputOnCommand");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Fan Input Off Command"),
            System.ComponentModel.DefaultValue("M107"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.fan.input_off_command")
        ]
        public System.String SwitchFanInputOffCommand
        {
            get
            {
                System.String value = "M107";
                object obj = get("switch.fan.input_off_command");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.fan.input_off_command", value);
                this.NotifyPropertyChanged("SwitchFanInputOffCommand");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute("pwm output settable with S parameter in the input_on_comand"),
            System.ComponentModel.DisplayNameAttribute("Switch Fan Output Type"),
            System.ComponentModel.DefaultValue("pwm"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.fan.output_type")
        ]
        public System.String SwitchFanOutputType
        {
            get
            {
                System.String value = "pwm";
                object obj = get("switch.fan.output_type");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.fan.output_type", value);
                this.NotifyPropertyChanged("SwitchFanOutputType");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Misc Input On Command"),
            System.ComponentModel.DefaultValue("M42"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.misc.input_on_command")
        ]
        public System.String SwitchMiscInputOnCommand
        {
            get
            {
                System.String value = "M42";
                object obj = get("switch.misc.input_on_command");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.misc.input_on_command", value);
                this.NotifyPropertyChanged("SwitchMiscInputOnCommand");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Switch Misc Input Off Command"),
            System.ComponentModel.DefaultValue("M43"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.misc.input_off_command")
        ]
        public System.String SwitchMiscInputOffCommand
        {
            get
            {
                System.String value = "M43";
                object obj = get("switch.misc.input_off_command");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.misc.input_off_command", value);
                this.NotifyPropertyChanged("SwitchMiscInputOffCommand");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Switch module for fan control"),
            System.ComponentModel.DescriptionAttribute("just an on or off pin"),
            System.ComponentModel.DisplayNameAttribute("Switch Misc Output Type"),
            System.ComponentModel.DefaultValue("digital"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("switch.misc.output_type")
        ]
        public System.String SwitchMiscOutputType
        {
            get
            {
                System.String value = "digital";
                object obj = get("switch.misc.output_type");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("switch.misc.output_type", value);
                this.NotifyPropertyChanged("SwitchMiscOutputType");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("automatically toggle a switch at a specified temperature."),
            System.ComponentModel.DescriptionAttribute("first character of the temperature control designator to use as the temperature sensor to monitor"),
            System.ComponentModel.DisplayNameAttribute("Temperature Switch Hotend Designator"),
            System.ComponentModel.DefaultValue("T"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperatureswitch.hotend.designator")
        ]
        public System.String TemperatureSwitchHotendDesignator
        {
            get
            {
                System.String value = "T";
                object obj = get("temperatureswitch.hotend.designator");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperatureswitch.hotend.designator", value);
                this.NotifyPropertyChanged("TemperatureSwitchHotendDesignator");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("automatically toggle a switch at a specified temperature."),
            System.ComponentModel.DescriptionAttribute("select which switch to use, matches the name of the defined switch"),
            System.ComponentModel.DisplayNameAttribute("Temperature Switch Hotend Switch"),
            System.ComponentModel.DefaultValue("misc"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("temperatureswitch.hotend.switch")
        ]
        public System.String TemperatureSwitchHotendSwitch
        {
            get
            {
                System.String value = "misc";
                object obj = get("temperatureswitch.hotend.switch");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("temperatureswitch.hotend.switch", value);
                this.NotifyPropertyChanged("TemperatureSwitchHotendSwitch");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("add a ! to invert if endstop is NO connected to ground"),
            System.ComponentModel.DisplayNameAttribute("Alpha Min End Stop"),
            System.ComponentModel.DefaultValue("1.24^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_min_endstop")
        ]
        public System.String AlphaMinEndStop
        {
            get
            {
                System.String value = "1.24^";
                object obj = get("alpha_min_endstop");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("alpha_min_endstop", value);
                this.NotifyPropertyChanged("AlphaMinEndStop");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("NOTE set to nc if this is not installed"),
            System.ComponentModel.DisplayNameAttribute("Alpha Max End Stop"),
            System.ComponentModel.DefaultValue("1.25^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_max_endstop")
        ]
        public System.String AlphaMaxEndStop
        {
            get
            {
                System.String value = "1.25^";
                object obj = get("alpha_max_endstop");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("alpha_max_endstop", value);
                this.NotifyPropertyChanged("AlphaMaxEndStop");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("or set to home_to_max and set alpha_max"),
            System.ComponentModel.DisplayNameAttribute("Alpha Homing Direction"),
            System.ComponentModel.DefaultValue("home_to_min"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("alpha_homing_direction")
        ]
        public System.String AlphaHomingDirection
        {
            get
            {
                System.String value = "home_to_min";
                object obj = get("alpha_homing_direction");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("alpha_homing_direction", value);
                this.NotifyPropertyChanged("AlphaHomingDirection");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Beta Min End Stop"),
            System.ComponentModel.DefaultValue("1.26^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_min_endstop")
        ]
        public System.String BetaMinEndStop
        {
            get
            {
                System.String value = "1.26^";
                object obj = get("beta_min_endstop");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("beta_min_endstop", value);
                this.NotifyPropertyChanged("BetaMinEndStop");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Beta Max End Stop"),
            System.ComponentModel.DefaultValue("1.27^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_max_endstop")
        ]
        public System.String BetaMaxEndStop
        {
            get
            {
                System.String value = "1.27^";
                object obj = get("beta_max_endstop");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("beta_max_endstop", value);
                this.NotifyPropertyChanged("BetaMaxEndStop");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Beta Homing Direction"),
            System.ComponentModel.DefaultValue("home_to_min"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("beta_homing_direction")
        ]
        public System.String BetaHomingDirection
        {
            get
            {
                System.String value = "home_to_min";
                object obj = get("beta_homing_direction");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("beta_homing_direction", value);
                this.NotifyPropertyChanged("BetaHomingDirection");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Gamma Min End Stop"),
            System.ComponentModel.DefaultValue("1.28^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_min_endstop")
        ]
        public System.String GammaMinEndStop
        {
            get
            {
                System.String value = "1.28^";
                object obj = get("gamma_min_endstop");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("gamma_min_endstop", value);
                this.NotifyPropertyChanged("GammaMinEndStop");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Gamma Max End Stop"),
            System.ComponentModel.DefaultValue("1.29^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_max_endstop")
        ]
        public System.String GammaMaxEndStop
        {
            get
            {
                System.String value = "1.29^";
                object obj = get("gamma_max_endstop");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("gamma_max_endstop", value);
                this.NotifyPropertyChanged("GammaMaxEndStop");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute(""),
            System.ComponentModel.DisplayNameAttribute("Gamma Homing Direction"),
            System.ComponentModel.DefaultValue("home_to_min"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("gamma_homing_direction")
        ]
        public System.String GammaHomingDirection
        {
            get
            {
                System.String value = "home_to_min";
                object obj = get("gamma_homing_direction");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("gamma_homing_direction", value);
                this.NotifyPropertyChanged("GammaHomingDirection");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Endstops"),
            System.ComponentModel.DescriptionAttribute("optional order in which axis will home, default is they all home at the same time, if this is set it will force each axis to home one at a time in the specified order (x axis followed by y then z last)"),
            System.ComponentModel.DisplayNameAttribute("Homing Order"),
            System.ComponentModel.DefaultValue("XYZ"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("homing_order")
        ]
        public System.String HomingOrder
        {
            get
            {
                System.String value = "XYZ";
                object obj = get("homing_order");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("homing_order", value);
                this.NotifyPropertyChanged("HomingOrder");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("optional Z probe"),
            System.ComponentModel.DescriptionAttribute("pin probe is attached to if NC remove the !"),
            System.ComponentModel.DisplayNameAttribute("Z Probe Probe Pin"),
            System.ComponentModel.DefaultValue("1.28!^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("zprobe.probe_pin")
        ]
        public System.String ZProbeProbePin
        {
            get
            {
                System.String value = "1.28!^";
                object obj = get("zprobe.probe_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("zprobe.probe_pin", value);
                this.NotifyPropertyChanged("ZProbeProbePin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("the first probe point (x,y) optional may be defined with M557"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Point 1"),
            System.ComponentModel.DefaultValue("100.0,0.0"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.point1")
        ]
        public System.String LevelingStrategyThreePointLevelingPoint1
        {
            get
            {
                System.String value = "100.0,0.0";
                object obj = get("leveling-strategy.three-point-leveling.point1");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.point1", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingPoint1");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("the second probe point (x,y)"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Point 2"),
            System.ComponentModel.DefaultValue("200.0,200.0"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.point2")
        ]
        public System.String LevelingStrategyThreePointLevelingPoint2
        {
            get
            {
                System.String value = "200.0,200.0";
                object obj = get("leveling-strategy.three-point-leveling.point2");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.point2", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingPoint2");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("zprobe leveling strategy"),
            System.ComponentModel.DescriptionAttribute("the third probe point (x,y)"),
            System.ComponentModel.DisplayNameAttribute("Leveling Strategy Three Point Leveling Point 3"),
            System.ComponentModel.DefaultValue("0.0,200.0"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("leveling-strategy.three-point-leveling.point3")
        ]
        public System.String LevelingStrategyThreePointLevelingPoint3
        {
            get
            {
                System.String value = "0.0,200.0";
                object obj = get("leveling-strategy.three-point-leveling.point3");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("leveling-strategy.three-point-leveling.point3", value);
                this.NotifyPropertyChanged("LevelingStrategyThreePointLevelingPoint3");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Panel"),
            System.ComponentModel.DescriptionAttribute("set type of panel"),
            System.ComponentModel.DisplayNameAttribute("Panel LCD"),
            System.ComponentModel.DefaultValue("smoothiepanel"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.lcd")
        ]
        public System.String PanelLcd
        {
            get
            {
                System.String value = "smoothiepanel";
                object obj = get("panel.lcd");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.lcd", value);
                this.NotifyPropertyChanged("PanelLcd");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Panel"),
            System.ComponentModel.DescriptionAttribute("encoder pin"),
            System.ComponentModel.DisplayNameAttribute("Panel Encoder A Pin"),
            System.ComponentModel.DefaultValue("3.25!^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.encoder_a_pin")
        ]
        public System.String PanelEncoderAPin
        {
            get
            {
                System.String value = "3.25!^";
                object obj = get("panel.encoder_a_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.encoder_a_pin", value);
                this.NotifyPropertyChanged("PanelEncoderAPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("Panel"),
            System.ComponentModel.DescriptionAttribute("encoder pin"),
            System.ComponentModel.DisplayNameAttribute("Panel Encoder B Pin"),
            System.ComponentModel.DefaultValue("3.26!^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.encoder_b_pin")
        ]
        public System.String PanelEncoderBPin
        {
            get
            {
                System.String value = "3.26!^";
                object obj = get("panel.encoder_b_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.encoder_b_pin", value);
                this.NotifyPropertyChanged("PanelEncoderBPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("click button        ; GLCD EXP1 Pin 2"),
            System.ComponentModel.DisplayNameAttribute("Panel Click Button Pin"),
            System.ComponentModel.DefaultValue("1.30!^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.click_button_pin")
        ]
        public System.String PanelClickButtonPin
        {
            get
            {
                System.String value = "1.30!^";
                object obj = get("panel.click_button_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.click_button_pin", value);
                this.NotifyPropertyChanged("PanelClickButtonPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("back button         ; GLCD EXP2 Pin 8"),
            System.ComponentModel.DisplayNameAttribute("Panel Back Button Pin"),
            System.ComponentModel.DefaultValue("2.11!^"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.back_button_pin")
        ]
        public System.String PanelBackButtonPin
        {
            get
            {
                System.String value = "2.11!^";
                object obj = get("panel.back_button_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.back_button_pin", value);
                this.NotifyPropertyChanged("PanelBackButtonPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("up button if used"),
            System.ComponentModel.DisplayNameAttribute("Panel Up Button Pin"),
            System.ComponentModel.DefaultValue("0.1!"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.up_button_pin")
        ]
        public System.String PanelUpButtonPin
        {
            get
            {
                System.String value = "0.1!";
                object obj = get("panel.up_button_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.up_button_pin", value);
                this.NotifyPropertyChanged("PanelUpButtonPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("reprap discount GLCD"),
            System.ComponentModel.DescriptionAttribute("down button if used"),
            System.ComponentModel.DisplayNameAttribute("Panel Down Button Pin"),
            System.ComponentModel.DefaultValue("0.0!"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("panel.down_button_pin")
        ]
        public System.String PanelDownButtonPin
        {
            get
            {
                System.String value = "0.0!";
                object obj = get("panel.down_button_pin");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("panel.down_button_pin", value);
                this.NotifyPropertyChanged("PanelDownButtonPin");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("network settings"),
            System.ComponentModel.DescriptionAttribute("use dhcp to get ip address"),
            System.ComponentModel.DisplayNameAttribute("Network IP Address"),
            System.ComponentModel.DefaultValue("auto"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("network.ip_address")
        ]
        public System.String NetworkIpAddress
        {
            get
            {
                System.String value = "auto";
                object obj = get("network.ip_address");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("network.ip_address", value);
                this.NotifyPropertyChanged("NetworkIpAddress");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("network settings"),
            System.ComponentModel.DescriptionAttribute("the ip mask"),
            System.ComponentModel.DisplayNameAttribute("Network IP Mask"),
            System.ComponentModel.DefaultValue("255.255.255.0"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("network.ip_mask")
        ]
        public System.String NetworkIpMask
        {
            get
            {
                System.String value = "255.255.255.0";
                object obj = get("network.ip_mask");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("network.ip_mask", value);
                this.NotifyPropertyChanged("NetworkIpMask");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("network settings"),
            System.ComponentModel.DescriptionAttribute("the gateway address"),
            System.ComponentModel.DisplayNameAttribute("Network IP Gateway"),
            System.ComponentModel.DefaultValue("192.168.3.1"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("network.ip_gateway")
        ]
        public System.String NetworkIpGateway
        {
            get
            {
                System.String value = "192.168.3.1";
                object obj = get("network.ip_gateway");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("network.ip_gateway", value);
                this.NotifyPropertyChanged("NetworkIpGateway");
            }
        }

        [
            System.ComponentModel.CategoryAttribute("network settings"),
            System.ComponentModel.DescriptionAttribute("override the mac address, only do this if you have a conflict"),
            System.ComponentModel.DisplayNameAttribute("Network MAC Override"),
            System.ComponentModel.DefaultValue("xx.xx.xx.xx.xx.xx"),
            System.ComponentModel.ReadOnly(false),
            System.ComponentModel.Browsable(true),
            SmoothieInterface.ReferenceAttribute("network.mac_override")
        ]
        public System.String NetworkMacOverride
        {
            get
            {
                System.String value = "xx.xx.xx.xx.xx.xx";
                object obj = get("network.mac_override");
                if (obj is System.String)
                    value = (System.String)obj;
                return value;
            }
            set
            {
                set("network.mac_override", value);
                this.NotifyPropertyChanged("NetworkMacOverride");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            this.m_HasChanged = true;
        }
    }
}
