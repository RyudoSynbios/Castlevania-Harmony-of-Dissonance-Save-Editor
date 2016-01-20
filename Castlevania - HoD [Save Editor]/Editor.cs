using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Castlevania___HoD__Save_Editor_
{
    class Editor
    {
        private String filePath = "";

        public Editor(String newFile)
        {
            filePath = newFile;
        }

        public decimal readData(Int32 newPosition, int bytesToRead)
        {
            try
            {
                FileStream reader = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                byte[] tempData = new byte[bytesToRead];
                decimal output = -1;

                if (newPosition > reader.Length)
                {
                    reader.Flush();
                    reader.Close();
                    return output;
                }

                reader.Position = newPosition;

                if (bytesToRead == 1)
                {
                    output = reader.ReadByte();
                    reader.Flush();
                    reader.Close();
                    return output;
                }

                for (int i = 0; i < tempData.Length; ++i)
                {
                    tempData[i] = (byte)reader.ReadByte();
                }

                if (bytesToRead == 2)
                    output = (decimal)BitConverter.ToInt16(tempData, 0);
                else if (bytesToRead == 4)
                    output = (decimal)BitConverter.ToInt32(tempData, 0);

                reader.Flush();
                reader.Close();

                return output;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        public void writeData(Int32 newPosition, int bytesToWrite, decimal value)
        {
            try
            {
                FileStream writer = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                byte[] tempData = new byte[bytesToWrite];

                if (newPosition > writer.Length)
                {
                    writer.Flush();
                    writer.Close();

                    return;
                }

                writer.Position = newPosition;

                if (bytesToWrite == 2)
                    tempData = BitConverter.GetBytes((Int16)value);
                else if (bytesToWrite == 4)
                    tempData = BitConverter.GetBytes((Int32)value);
                else
                {
                    writer.WriteByte((byte)value);
                    writer.Flush();
                    writer.Close();
                    return;
                }

                for (int i = 0; i < tempData.Length; ++i)
                {
                    writer.WriteByte(tempData[i]);
                }

                writer.Flush();
                writer.Close();
                return;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
        }
    }
}
