# Métodos de busca disponíveis em engines

Em motores de jogos como Unity e Unreal, a busca é uma parte fundamental para otimizar a navegação, inteligência artificial (IA), e sistemas de física, como em jogos 3D e 2D. 

### 1. **Unity**

Na Unity, a busca pode envolver diferentes aspectos como navegação, IA e busca de objetos. 

#### Métodos de Busca:

- **Busca A* (A Star)**: Utilizada principalmente para sistemas de navegação e IA. A Unity não tem um sistema nativo completo para A* até sua versão mais recente, mas pode-se implementar ou usar pacotes para essa funcionalidade.
  
- **Raycasting**: Muito usado para encontrar objetos em um espaço 3D, como detectar colisões, pegar objetos e fazer buscas em linha reta, com raycast (raio).

- **NavMesh**: A Unity possui um sistema de navegação nativo chamado **NavMesh** (Navigation Mesh). O NavMesh permite que os agentes (NPCs) busquem caminhos através do ambiente, evitando obstáculos. A busca de caminhos é feita utilizando o algoritmo de A* internamente.

#### Bibliotecas e Pacotes:
- **NavMesh**: Nativo da Unity.
- **Unity ML-Agents**: Para IA baseada em aprendizado de máquina, pode ser usada para busca e tomada de decisão mais complexa (não é nativo, mas é amplamente utilizado e gratuito).
- **Pathfinding Project**: Biblioteca de código aberto para implementar A* e outros algoritmos de busca. Não é nativa, mas é bastante popular.

#### Exemplo de Jogo:
- **"Monument Valley"** (embora a Unity tenha sido usada de uma maneira mais geral, o uso de IA para navegação de personagens pode ser considerado um exemplo simples de uso do sistema de navegação).

### 2. **Unreal Engine**

Na Unreal, as buscas também podem cobrir uma gama de funcionalidades, desde IA até navegação de personagem.

#### Métodos de Busca:

- **Busca A***: Assim como na Unity, a Unreal Engine também oferece suporte para A* para navegação e IA.
  
- **NavMesh**: Unreal também possui o **NavMesh** integrado. A Unreal tem um sistema de navegação mais robusto que é utilizado para AI e movimento de agentes NPC, muito similar ao que a Unity oferece.

- **Raycasting**: Também disponível na Unreal para detecção de colisões, busca de objetos e outras funcionalidades.

#### Bibliotecas e Pacotes:
- **NavMesh**: Nativo da Unreal.
- **Behavior Trees**: Sistema nativo para IA que pode ser usado para determinar comportamentos e decisões em um jogo.
- **Unreal Engine AI Framework**: Usado para navegação, percepção de agentes, etc.

#### Exemplo de Jogo:
- **"Fortnite"**: A Unreal Engine foi amplamente utilizada em **Fortnite**, e seu sistema de navegação com o **NavMesh** é essencial para os bots e NPCs que se movem no mundo. Além disso, a Unreal também usa Behavior Trees para criar comportamentos complexos para IA.

### Resumo das Ferramentas e Exemplos:

| **Método/Funcionalidade**    | **Unity**                               | **Unreal Engine**                      |
|------------------------------|-----------------------------------------|----------------------------------------|
| **Algoritmo de Busca A\***   | Não nativo, (Pathfinding Project)       | Nativo, através do NavMesh             |
| **Navegação (NavMesh)**      | Nativo (NavMesh)                        | Nativo (NavMesh)                       |
| **Raycasting**               | Nativo (Raycast)                        | Nativo (Line Trace)                    |
| **Behavior Trees**           | Não nativo, (Unity ML-Agents)           | Nativo (Behavior Trees)                |

### Conclusão:
- **Unity** tem sistemas nativos como o **NavMesh** e pode ser extendido com pacotes como o **Pathfinding Project** e o **Unity ML-Agents** para IA mais avançada.
- **Unreal Engine** tem suporte robusto com **NavMesh**, **Behavior Trees** e outras ferramentas nativas para navegação e IA.

