﻿
/*
Copyright Okimi 2015-2016 (contact at okimi dot net)

Ce logiciel est un programme informatique servant à compiler un fichier
Blockly4Thymio (.b4t), à le transfomer en fichier Aseba (.aesl) et le
transmettre à un robot Thymio. Ce logiciel fait partie d'une suites de
logiciels nommée Blockly4Thymio.

Ce logiciel est régi par la licence CeCILL soumise au droit français et
respectant les principes de diffusion des logiciels libres. Vous pouvez
utiliser, modifier et/ou redistribuer ce programme sous les conditions
de la licence CeCILL telle que diffusée par le CEA, le CNRS et l'INRIA 
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
pris connaissance de la licence CeCILL, et que vous en avez accepté les
termes.

===============================================================================

Copyright Okimi 2015-2016 (contact at okimi dot net)

This software is a computer program whose purpose is to compil Blockly4Thymio
file (.b4t), to transform it into Aseba file (.aesl) and send it to Thymio
Robot. This software is part of Blockly4Thymio serie.

This software is governed by the CeCILL license under French law and
abiding by the rules of distribution of free software.  You can  use, 
modify and/ or redistribute the software under the terms of the CeCILL
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
knowledge of the CeCILL license and that you accept its terms.
*/


using 	System;



namespace		Blockly4Thymio {
public class 	Messages {

	public enum TYPE {
		BOUCLE_INFÉRIEURE_A_1 = 1,
		BOUCLE_SUPÉRIEURE_A_100,
		DURÉE_INFÉRIEURE_A_0,
		DURÉE_SUPÉRIEURE_A_60,
		DISTANCE_INFÉRIEURE_A_1,
		DISTANCE_SUPÉRIEURE_A_100,
		ANGLE_INFÉRIEURE_A_0,
		ANGLE_SUPÉRIEURE_A_360,
		ASEBAMASSLOADER_INTROUVABLE,
		PAS_D_INSTRUCTION_DE_DEPART,
		LECTURE_DU_FICHIER_B4T,
		COMPILATION_DU_FICHIER_B4T,
		TRANSFERT_DU_FICHIER_ASEBA,
		FICHIER_N_EXISTE_PAS,
		FICHIER_NON_LISIBLE
	}




	/// <summary>
	/// Liste des messages d'erreur.
	/// </summary>
	/// <returns>String</returns>
	public	static	String	Message( int _numéro ) {

		switch( _numéro ) {
		
		case (int)TYPE.BOUCLE_INFÉRIEURE_A_1 :		return "Dans une des boucle, le nombre de répétition est plus petit que 1. Celui-ci a été corrigé pour être au moins à 1.";
		case (int)TYPE.BOUCLE_SUPÉRIEURE_A_100 :	return "Dans une des boucle, le nombre de répétition est plus grand que 100. Celui-ci a été corrigé pour être à 100.";
		
		case (int)TYPE.DURÉE_INFÉRIEURE_A_0 :		return "Une durée est plus petite que 0s. Celle-ci a été corrigée pour être au moins à 0 seconde.";
		case (int)TYPE.DURÉE_SUPÉRIEURE_A_60 :		return "Une durée est plus grande que 60s. Celle-ci a été corrigée pour être à 60 secondes.";
		
		case (int)TYPE.DISTANCE_INFÉRIEURE_A_1 :	return "Une distance est plus petite que 1cm. Celle-ci a été corrigée pour être au moins à 1cm.";
		case (int)TYPE.DISTANCE_SUPÉRIEURE_A_100 :	return "Une distance est plus grande que 100cm. Celle-ci a été corrigée pour être de 100cm.";

		case (int)TYPE.ANGLE_INFÉRIEURE_A_0 :		return "Un angle est plus petit que 0°. Celle-ci a été corrigé pour être au moins à 0°.";
		case (int)TYPE.ANGLE_SUPÉRIEURE_A_360 :		return "Un angle est plus grand que 360°. Celle-ci a été corrigé pour être de 360°.";

		case (int)TYPE.ASEBAMASSLOADER_INTROUVABLE:	return "Erreur ! L'exécutable {0} pour transmettre le fichier .aesl au robot Thymio n'existe pas.";

		case (int)TYPE.PAS_D_INSTRUCTION_DE_DEPART:	return "Il n'y a pas d'instruction de départ dans le fichier {0} .";

		case (int)TYPE.LECTURE_DU_FICHIER_B4T:		return "Lecture du fichier b4t...";
		case (int)TYPE.COMPILATION_DU_FICHIER_B4T:	return "Compilation du fichier b4t...";
		case (int)TYPE.TRANSFERT_DU_FICHIER_ASEBA:	return "Transfert du fichier Aseba...";

		case (int)TYPE.FICHIER_N_EXISTE_PAS :		return "Erreur ! Le fichier {0} n'existe pas.";

		case (int)TYPE.FICHIER_NON_LISIBLE :		return "Erreur lors de la lecture du fichier {0} .";

		}

		throw new Exception( "Le message " + _numéro + " n'existe pas dans la liste des  messages." );

	}


}
}
