PGDMP          #                {         	   Pekerjaan    15.2    15.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16420 	   Pekerjaan    DATABASE     �   CREATE DATABASE "Pekerjaan" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "Pekerjaan";
                hamzah    false            �            1259    16452    pekerjaan_it    TABLE     1  CREATE TABLE public.pekerjaan_it (
    id_pekerjaan_it integer NOT NULL,
    nama_pekerjaan character varying NOT NULL,
    deskripsi_pekerjaan text NOT NULL,
    kualifikasi_pendidikan text NOT NULL,
    skills text NOT NULL,
    rerata_gaji text NOT NULL,
    lokasi_kerja character varying NOT NULL
);
     DROP TABLE public.pekerjaan_it;
       public         heap    hamzah    false            �            1259    16451     pekerjaan_it_id_pekerjaan_it_seq    SEQUENCE     �   CREATE SEQUENCE public.pekerjaan_it_id_pekerjaan_it_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.pekerjaan_it_id_pekerjaan_it_seq;
       public          hamzah    false    215            �           0    0     pekerjaan_it_id_pekerjaan_it_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.pekerjaan_it_id_pekerjaan_it_seq OWNED BY public.pekerjaan_it.id_pekerjaan_it;
          public          hamzah    false    214            e           2604    16455    pekerjaan_it id_pekerjaan_it    DEFAULT     �   ALTER TABLE ONLY public.pekerjaan_it ALTER COLUMN id_pekerjaan_it SET DEFAULT nextval('public.pekerjaan_it_id_pekerjaan_it_seq'::regclass);
 K   ALTER TABLE public.pekerjaan_it ALTER COLUMN id_pekerjaan_it DROP DEFAULT;
       public          hamzah    false    214    215    215            �          0    16452    pekerjaan_it 
   TABLE DATA           �   COPY public.pekerjaan_it (id_pekerjaan_it, nama_pekerjaan, deskripsi_pekerjaan, kualifikasi_pendidikan, skills, rerata_gaji, lokasi_kerja) FROM stdin;
    public          hamzah    false    215   �       �           0    0     pekerjaan_it_id_pekerjaan_it_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.pekerjaan_it_id_pekerjaan_it_seq', 46, true);
          public          hamzah    false    214            g           2606    16459    pekerjaan_it pekerjaan_it_pk 
   CONSTRAINT     g   ALTER TABLE ONLY public.pekerjaan_it
    ADD CONSTRAINT pekerjaan_it_pk PRIMARY KEY (id_pekerjaan_it);
 F   ALTER TABLE ONLY public.pekerjaan_it DROP CONSTRAINT pekerjaan_it_pk;
       public            hamzah    false    215            �   }  x�]��R�@�ϫ��' 6TR���!e
�!��5HS^ͪ�'��>���t������g�ƈ�U?�p����<�e�&����A'hҗUe�%l���	#��l]�����Ϣ��d6�{X~9[,�1�huq�4O������2r���u�#�N��#��2�	w�-�������l�J]�7�G�9/�a%h!f��]�p�~a�YBfX
�5��G'q~D��k+l.�����x���( D�f� g�k�!W�t���NR�#�<$Q�%����)IU=rHhͪw�vtх��E�Ä��ף�o(}��/ͥu��+X��{��٣�i�/�>z����s;������z�������c��]�E{!��=k��?��9     