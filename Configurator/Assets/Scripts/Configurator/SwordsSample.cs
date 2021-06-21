using System.Collections;
using UnityEngine;

namespace Configurator
{
    public class SwordsSample : MonoBehaviour
    {
        [SerializeField] private Attachment[] _handles;
        [SerializeField] private Attachment[] _guards;
        [SerializeField] private Attachment[] _blades;

        [SerializeField] private int _swordsAmount;
        
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
                StartCoroutine(GenerateSwords());

        }

        private IEnumerator GenerateSwords()
        {
            for (int i = 0; i < _swordsAmount; i++)
            {
                yield return new WaitForSeconds(0.3f);
                StartCoroutine(GenerateSword(i));
            }
        }

        private IEnumerator GenerateSword(int index)
        {
            var sword = Instantiate(_handles[Random.Range(0, _handles.Length)]);
            sword.transform.position = new Vector3(0, 0, index * 3); 
            yield return new WaitForSeconds(0.1f);
            
            sword.Attach(_guards[Random.Range(0, _guards.Length)]);
            yield return new WaitForSeconds(0.1f);
            sword.Attach(_blades[Random.Range(0, _blades.Length)]);
        }
    }
}