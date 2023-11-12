using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using TMPro;
using Leap.Unity;
// using Leap;

public class Esp32Connection : MonoBehaviour
{
    public string serverIP; // Replace with the actual IP address of your ESP32
    public int serverPort = 1234;

    public GameObject finger_thumb;
    public GameObject finger_index;
    public GameObject finger_middle;
    public TMP_Text textUI;

    private TcpClient tcpClient;
    private NetworkStream networkStream;
    // private byte[] receiveBuffer = new byte[1024];
    // public LeapProvider provider;
    // private Hand rightHand
    private string previous_finger_data = "";
    
    // Time-related variables
    // private float accumulatedTime = 0f;
    // private float delayThreshold = 0.2f; // 10ms in seconds

    void Start()
    {
        ConnectToESP32();
        // rightHand = provider.GetHand(Chirality.Right);

    }

    void Update()
    {
        if (tcpClient == null || !tcpClient.Connected)
        {
            textUI.text = "Status: Not Connected";
            return;
        }

        // if (networkStream.DataAvailable)
        // {
        //     int bytesRead = networkStream.Read(receiveBuffer, 0, receiveBuffer.Length);
        //     string receivedData = Encoding.UTF8.GetString(receiveBuffer, 0, bytesRead);

        //     // Process received data as needed
        //     Debug.Log("Received data: " + receivedData);
        //     textUI.text = "Status: Connected";
        // }

        bool thumb_collision = HasCollided(finger_thumb);
        bool index_collision = HasCollided(finger_index);
        bool middle_collision = HasCollided(finger_middle);

        string current_finger_data = stringFingerMaps(thumb_collision, index_collision, middle_collision);

        
        
        if(Hands.Right != null){
            if(string.Compare(current_finger_data, previous_finger_data, StringComparison.OrdinalIgnoreCase) != 0){
                    textUI.text = current_finger_data;
                    SendDataToESP32(current_finger_data);
                    previous_finger_data = current_finger_data;
            }
        }
        else{
            current_finger_data = "0_0_0";
            textUI.text = "right hand removed "+current_finger_data;
            SendDataToESP32(current_finger_data);
        }

         
            
    }

    private bool HasCollided(GameObject gameObjectToCheck)
    {
        // Collider array to store information about the collisions
        Collider[] colliders = Physics.OverlapBox(gameObjectToCheck.transform.position, gameObjectToCheck.GetComponent<Collider>().bounds.extents);

        // Check if there are any colliders (other than the object itself) in the array
        // Debug.Log(gameObjectToCheck.name + " " + colliders.Length);
        // if(colliders.Length > 1)
        //     Debug.Log(gameObjectToCheck.name + " " + colliders[1].gameObject.name);
        return colliders.Length > 1; // If there's only one collider, it's the object itself
    }

    string stringFingerMaps(bool finger_1, bool finger_2, bool  finger_3){

        return string.Format("{0}_{1}_{2}", Convert.ToInt32(finger_1), Convert.ToInt32(finger_2), Convert.ToInt32(finger_3));
    }

    void ConnectToESP32()
    {
        try
        {
            tcpClient = new TcpClient(serverIP, serverPort);
            networkStream = tcpClient.GetStream();
            Debug.Log("Connected to ESP32");
        }
        catch (Exception e)
        {
            Debug.LogError("Error connecting to ESP32: " + e.Message);
        }
    }

    void SendDataToESP32(string data)
    {
        if (tcpClient == null || !tcpClient.Connected)
        {
            Debug.LogError("Not connected to ESP32.");
            return;
        }

        try
        {

             data += "\n";
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            networkStream.Write(dataBytes, 0, dataBytes.Length);
            Debug.Log("Sent data to ESP32: " + data);
        }
        catch (Exception e)
        {
            Debug.LogError("Error sending data to ESP32: " + e.Message);
        }
    }
}
