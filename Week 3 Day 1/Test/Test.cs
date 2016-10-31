using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week_3_Day_1;
using System.Linq;
using System.Reflection;

namespace Test
{
    [TestClass]
    public class Test
    {
        static Type t = null;
        static object o = null;
        static int counter = 0;

        // ====================================
        // TEST 1 
        // ====================================

        [TestMethod]
        public void Square_class_is_created()
        {
            t = Program.MagicallyCheckClass("Square");

            if (t == null)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Square_class_zero_parameter_constructor_is_created()
        {
            o = Activator.CreateInstance(t);

            if (o == null)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Square_class_one_parameter_constructor_is_created()
        {
            o = Activator.CreateInstance(t, new object[] {1});

            if (o == null)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        // ====================================
        // TEST 2 
        // ====================================

        [TestMethod]
        public void Teacher_class_is_created()
        {
            t = Program.MagicallyCheckClass("Teacher");

            if (t == null)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Teacher_class_subject_field_is_created()
        {
            FieldInfo[] privateFields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] publicFields = t.GetFields();

            bool found = false;

            int i = 0;
            while (i < privateFields.Length && !found)
            {
                if (privateFields[i].ToString() == "System.String subject")
                {
                    found = true;
                }

                i++;
            }

            i = 0;
            while (i < publicFields.Length && !found)
            {
                if (publicFields[i].ToString() == "System.String subject")
                {
                    found = true;
                }

                i++;
            }

            if (!found)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Teacher_class_subject_field_is_private()
        {
            FieldInfo[] privateFields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            bool found = false;

            int i = 0;
            while (i < privateFields.Length && !found)
            {
                if (privateFields[i].ToString() == "System.String subject")
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }

            if (!privateFields[i].GetType().IsSealed)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Teacher_class_constructor_is_created()
        {
            o = Activator.CreateInstance(t, new object[] { "Budi", 30, "Mathematics" });

            if (o == null)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Teacher_class_teaching_method_is_created()
        {
            MethodInfo[] privateMethods = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] publicMethods = t.GetMethods();

            bool found = false;

            int i = 0;
            while (i < privateMethods.Length && !found)
            {
                if(privateMethods[i].ToString() == "System.String Teaching()")
                {
                    found = true;
                }

                i++;
            }

            i = 0;
            while (i < publicMethods.Length && !found)
            {
                if (publicMethods[i].ToString() == "System.String Teaching()")
                {
                    found = true;
                }

                i++;
            }

            if (!found)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Teacher_class_teaching_method_is_correct()
        {
            MethodInfo[] publicMethods = t.GetMethods();

            bool found = false;

            int i = 0;
            while (i < publicMethods.Length && !found)
            {
                if (publicMethods[i].ToString() == "System.String Teaching()")
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }

            Assert.AreEqual(publicMethods[i].Invoke(o, new object[] { }).ToString(), "Budi is teaching Mathematics right now.");
        }

        // ====================================
        // TEST 3
        // ====================================

        [TestMethod]
        public void Student_class_is_created()
        {
            t = Program.MagicallyCheckClass("Student");

            if (t == null)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Student_class_subject_field_is_created()
        {
            FieldInfo[] privateFields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] publicFields = t.GetFields();

            bool found = false;

            int i = 0;
            while (i < privateFields.Length && !found)
            {
                if (privateFields[i].ToString() == "System.String subject")
                {
                    found = true;
                }

                i++;
            }

            i = 0;
            while (i < publicFields.Length && !found)
            {
                if (publicFields[i].ToString() == "System.String subject")
                {
                    found = true;
                }

                i++;
            }

            if (!found)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Student_class_subject_field_is_private()
        {
            FieldInfo[] privateFields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            bool found = false;

            int i = 0;
            while (i < privateFields.Length && !found)
            {
                if (privateFields[i].ToString() == "System.String subject")
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }

            if (!privateFields[i].GetType().IsSealed)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Student_class_score_field_is_created()
        {
            FieldInfo[] privateFields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] publicFields = t.GetFields();

            bool found = false;

            int i = 0;
            while (i < privateFields.Length && !found)
            {
                if (privateFields[i].ToString() == "Int32 score")
                {
                    found = true;
                }

                i++;
            }

            i = 0;
            while (i < publicFields.Length && !found)
            {
                if (publicFields[i].ToString() == "Int32 score")
                {
                    found = true;
                }

                i++;
            }

            if (!found)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Student_class_score_field_is_private()
        {
            FieldInfo[] privateFields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            bool found = false;

            int i = 0;
            while (i < privateFields.Length && !found)
            {
                if (privateFields[i].ToString() == "Int32 score")
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }

            if (!privateFields[i].GetType().IsSealed)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }

        [TestMethod]
        public void Student_class_constructor_is_created()
        {
            o = Activator.CreateInstance(t, new object[] { "Budi", 30, "Mathematics", 100 });

            if (o == null)
            {
                Assert.Fail();
            }
            else
            {
                counter++;
            }
        }
    }
}
