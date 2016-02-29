
/*
Copyright Okimi 2015-2016 (contact at okimi dot net)

Ce logiciel est un programme informatique servant à compiler un fichier
Blockly4Thymio (.b4t), à le transfomer en fichier Aseba (.aesl) et le
transmettre à un robot Thymio. Ce logiciel fait partie d'une suites de
logiciels nommée Blockly4Thymio.

Ce logiciel est régi par la licence CeCILL-C soumise au droit français et
respectant les principes de diffusion des logiciels libres. Vous pouvez
utiliser, modifier et/ou redistribuer ce programme sous les conditions
de la licence CeCILL-C telle que diffusée par le CEA, le CNRS et l'INRIA 
sur le site "http://www.cecill.info".

En contrepartie de l'accessibilité au code source et des droits de copie,
de modification et de redistribution accordés par cette licence, il n'est
offert aux utilisateurs qu'une garantie limitée.  Pour les mêmes raisons,
seule une responsabilité restreinte pèse sur l'auteur du programme,  le
titulaire des droits patrimoniaux et les concédants successifs.

A cet égard  l'attention de l'utilisateur est attirée sur les risques
associés au chargement,  à l'utilisation,  à la modification et/ou au
développement et à la reproduction du logiciel par l'utilisateur étant 
donné sa spécificité de logiciel libre, qui peut le rendre complexe à 
manipuler et qui le réserve donc à des développeurs et des professionnels
avertis possédant  des  connaissances  informatiques approfondies.  Les
utilisateurs sont donc invités à charger  et  tester  l'adéquation  du
logiciel à leurs besoins dans des conditions permettant d'assurer la
sécurité de leurs systèmes et ou de leurs données et, plus généralement, 
à l'utiliser et l'exploiter dans les mêmes conditions de sécurité. 

Le fait que vous puissiez accéder à cet en-tête signifie que vous avez 
pris connaissance de la licence CeCILL-C, et que vous en avez accepté les
termes.

===============================================================================

Copyright Okimi 2015-2016 (contact at okimi dot net)

This software is a computer program whose purpose is to compil Blockly4Thymio
file (.b4t), to transform it into Aseba file (.aesl) and send it to Thymio
Robot. This software is part of Blockly4Thymio serie.

This software is governed by the CeCILL-C license under French law and
abiding by the rules of distribution of free software.  You can  use, 
modify and/ or redistribute the software under the terms of the CeCILL-C
license as circulated by CEA, CNRS and INRIA at the following URL
"http://www.cecill.info". 

As a counterpart to the access to the source code and  rights to copy,
modify and redistribute granted by the license, users are provided only
with a limited warranty  and the software's author,  the holder of the
economic rights,  and the successive licensors  have only  limited
liability. 

In this respect, the user's attention is drawn to the risks associated
with loading,  using,  modifying and/or developing or reproducing the
software by the user in light of its specific status of free software,
that may mean  that it is complicated to manipulate,  and  that  also
therefore means  that it is reserved for developers  and  experienced
professionals having in-depth computer knowledge. Users are therefore
encouraged to load and test the software's suitability as regards their
requirements in conditions enabling the security of their systems and/or 
data to be ensured and,  more generally, to use and operate it in the 
same conditions as regards security. 

The fact that you are presently reading this means that you have had
knowledge of the CeCILL-C license and that you accept its terms.
*/



using 	System;
using 	System.Xml;



namespace	Blockly4Thymio {
public	class	__Bloc {
	
    /*
     * Membres
     */
    protected	int						__UID;
	protected	int						__UIDDuSéquenceur;
	protected	int						__nombreDeSéquenceInitiale;

	protected	String					__nomDansBlockly;

    protected	__GroupeDInstructions	__groupe;				// Si un bloc appartient un groupe de blocs (boucles, conditions)
    
	protected	__Bloc					__blocPrécédent;		// Bloc précédent
	protected	__Bloc					__blocSuivant;			// Bloc suivant



	/*
	 * Propriétés vituelles.
	 * Déclarées pour êre traitées en Override dans les classes filles
	 */
	virtual	public	int		nombreDeSéquence { get { return __nombreDeSéquenceInitiale; } }
	
	virtual	public	int		nombreDeSéquenceInitiale { get { return __nombreDeSéquenceInitiale; } }

	virtual	public	String	codePourLeSéquenceur { get { return ""; } }
	


    /*
     * Propriétés publiques
     */
	public	int		UID { get { return __UID; } }

	public	int		UIDDuSéquenceur { get { return __UIDDuSéquenceur; } }

	public	__Bloc	blocSuivant {
	get { return __blocSuivant; }
	set { __blocSuivant = value ; }
	}

	public	__GroupeDInstructions	groupe { get { return __groupe; } }



	/*
	 * Constructeur
	 */
	public	__Bloc( int _UID, XmlNode _XMLDuBloc, __Bloc _blocPrécédent, __GroupeDInstructions _groupe ) {

		__UID = _UID;

        __nomDansBlockly = _XMLDuBloc.Attributes["type"].Value;

        __blocPrécédent = _blocPrécédent;

        __groupe = _groupe;

		if ( __blocPrécédent != null )
			__UIDDuSéquenceur = __blocPrécédent.__UIDDuSéquenceur;
		if ( __groupe != null )
			__UIDDuSéquenceur = __groupe.UIDDuSéquenceur;
		
		
    }



	/*
	 * Méthodes
	 */
	/// <summary>
	/// Sur une suite de blocs, trouve le dernier bloc
	/// </summary>
	/// <returns></returns>
	public	__Bloc	DernierBlocsSuivant() {
		if ( __blocSuivant == null )
			return this;
		else
			return __blocSuivant.DernierBlocsSuivant();
	}


}
}
