using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleToFindDirectoryCount
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            state1:
            string path = Console.ReadLine();
            int fileCount = 0;

            try
            {
                path = Path.GetFullPath(path);

                if (System.IO.Directory.Exists(path) == true)
                {
                    fileCount = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length;

                }

                if (fileCount > 0)
                {
                    Console.WriteLine("The Total Count of Files is: " + fileCount + "\n");
                }
                else
                {
                    Console.WriteLine("This directory doesn't exist, file count is: " + fileCount + "\n");
                }

                goto state1;


            }
            catch (ArgumentNullException ex)
            {
                //fileName is null.
                //throw ex; 
                Console.WriteLine(ex.Message);
                goto state1;

            }
            catch (System.Security.SecurityException ex)
            {
                //   System.Security.SecurityException:
                //     The caller does not have the required permission.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }
            catch (ArgumentException ex)
            {
                //   System.ArgumentException:
                //     The file name is empty, contains only white spaces, or contains invalid characters.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }
            catch (UnauthorizedAccessException ex)
            {
                //   System.UnauthorizedAccessException:
                //     Access to fileName is denied.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }
            catch (PathTooLongException ex)
            {
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }
            catch (NotSupportedException ex)
            {
                //   System.NotSupportedException:
                //     fileName contains a colon (:) in the middle of the string.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }
            catch (FileNotFoundException ex)
            {
                // System.FileNotFoundException
                //  The exception that is thrown when an attempt to access a file that does not
                //  exist on disk fails.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }
            catch (IOException ex)
            {
                //   System.IO.IOException:
                //     An I/O error occurred while opening the file.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }
            catch (Exception ex)
            {
                // Unknown Exception. Might be due to wrong case or nulll checks.
                //throw ex;
                Console.WriteLine(ex.Message);
                goto state1;
            }

            #endregion
        }
    }
}