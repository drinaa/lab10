﻿using System;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;

namespace SomeProject.Library.Client
{
    public class Client
    {
        public TcpClient tcpClient;
        /// <summary>
        /// Получение сообщения от сервера
        /// </summary>
        public OperationResult ReceiveMessageFromServer(NetworkStream stream)
        {
            try
            {
                StringBuilder recievedMessage = new StringBuilder();
                byte[] data = new byte[256];
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    recievedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                stream.Close();
                return new OperationResult(Result.OK, recievedMessage.ToString());
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.ToString());
            }
        }
        /// <summary>
        /// Отправка сообщения на сервер
        /// </summary>
        /// <param name="message">сообщение</param>
        public OperationResult SendMessageToServer(string message)
        {
            try
            {
                using (tcpClient = new TcpClient("127.0.0.1", 8081))
                {
                    using (NetworkStream stream = tcpClient.GetStream())
                    {
                        byte[] data = System.Text.Encoding.UTF8.GetBytes('0'+message);
                        stream.Write(data, 0, data.Length);
                        return ReceiveMessageFromServer(stream);
                    }
                }
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
        /// <summary>
        /// Отправка файла на сервер
        /// </summary>
        /// <param name="fName">имя файла</param>
        public OperationResult SendFileToServer(string fName)
        {
            try
            {
                using (tcpClient = new TcpClient("127.0.0.1", 8081))
                {
                    using (NetworkStream stream = tcpClient.GetStream())
                    {
                        byte[] filename = Encoding.UTF8.GetBytes('1'+fName.Substring(fName.LastIndexOf('.')+1) + '$');
                        stream.Write(filename, 0, filename.Length);
                        using (FileStream fstream = new FileStream(fName, FileMode.Open))
                        {
                            byte[] buff = new byte[4096];
                            int len = 0;
                            do
                            {
                                len = fstream.Read(buff, 0, buff.Length);
                                stream.Write(buff, 0, len);
                            } while (len != 0);
                        }
                        return ReceiveMessageFromServer(stream);
                    }
                }
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
    }
}