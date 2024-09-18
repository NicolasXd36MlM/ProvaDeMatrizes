using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class GameManager : MonoBehaviour
{
    public GameObject jogador1;
    public GameObject jogador2;
    public int linha = 5;
    public int coluna = 5;
    public float espacamento = 1.1f;

    private int[] Bloco;
    private int[] Conquista;


  
    #region Singleton
    public static GameManager instance;

    public int[] Bloco1 { get => Bloco;}

    private void Awake()
    {
        instance = this;
    }
    #endregion
    
    private void CriarGrade() 
    {
        
        for (int x = 0; x < linha; x++)
        {
         
            
            for (int y = 0; y < coluna; y++)
            {
               
                Vector3 position = new Vector3(x * espacamento, y * espacamento, 0);
                // Instancia um novo bloco na posi��o calculada.
                // Armazena o bloco instanciado na matriz.
            }
        }

        // Posiciona os jogadores no in�cio do jogo.
        // Calcula a posi��o inicial do jogador 1.
        // Calcula a posi��o inicial do jogador 2.

        // Ajusta a c�mera para se centrar na grade.
        // Posiciona a c�mera no centro da grade.
        // Ajusta o zoom da c�mera com base no tamanho da grade.

        // Instancia os jogadores nas suas posi��es iniciais.

       
       



    }
    
    public void ConquistarTerritorio() 
    {
       for (int conquista = 0; conquista < 10; conquista++) 
        {
            if (conquista == Bloco1.Length) //N�o sei oque poderia fazer aqui
            {
            
            
            }
        
        }
    
    }





    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
