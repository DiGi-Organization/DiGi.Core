#### [DiGi\.Core\.IO](DiGi.Core.IO.Overview.md 'DiGi\.Core\.IO\.Overview')

## DiGi\.Core\.IO\.File\.Classes Namespace
### Classes

<a name='DiGi.Core.IO.File.Classes.File'></a>

## File Class

Base class for files that support metadata and persistence via Zip archives\.

```csharp
public abstract class File : DiGi.Core.Classes.SerializableObject, DiGi.Core.IO.File.Interfaces.IFile, System.IDisposable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → File

Derived  
↳ [StorageFile&lt;TSerializableObject&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>')  
↳ [ValueFile&lt;TSerializableObject&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>')  
↳ [ValuesFile&lt;TSerializableObject&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>')

Implements [DiGi\.Core\.IO\.File\.Interfaces\.IFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile 'DiGi\.Core\.IO\.File\.Interfaces\.IFile'), [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='DiGi.Core.IO.File.Classes.File.File(DiGi.Core.IO.File.Classes.File)'></a>

## File\(File\) Constructor

Initializes a new instance of the [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') class by cloning another file's metadata\.

```csharp
public File(DiGi.Core.IO.File.Classes.File? file);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.File.File(DiGi.Core.IO.File.Classes.File).file'></a>

`file` [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File')

The source file to clone metadata from\.

<a name='DiGi.Core.IO.File.Classes.File.File(string)'></a>

## File\(string\) Constructor

Initializes a new instance of the [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') class with the specified path\.

```csharp
public File(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.File.File(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file\.

<a name='DiGi.Core.IO.File.Classes.File.File(System.Text.Json.Nodes.JsonObject)'></a>

## File\(JsonObject\) Constructor

Initializes a new instance of the [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') class from a JSON object\.

```csharp
public File(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.File.File(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing file data\.
### Properties

<a name='DiGi.Core.IO.File.Classes.File.MetadataStorage'></a>

## File\.MetadataStorage Property

Gets the metadata storage of the file\.

```csharp
internal DiGi.Core.IO.Classes.MetadataStorage MetadataStorage { internal get; }
```

#### Property Value
[DiGi\.Core\.IO\.Classes\.MetadataStorage](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.metadatastorage 'DiGi\.Core\.IO\.Classes\.MetadataStorage')

<a name='DiGi.Core.IO.File.Classes.File.Path'></a>

## File\.Path Property

Gets or sets the path of the file\.

```csharp
public string? Path { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.IO.File.Classes.File.Dispose()'></a>

## File\.Dispose\(\) Method

Releases all resources used by the file\.

```csharp
public void Dispose();
```

Implements [Dispose\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')

<a name='DiGi.Core.IO.File.Classes.File.GetMetadata_TMetadata_()'></a>

## File\.GetMetadata\<TMetadata\>\(\) Method

Retrieves metadata of the specified type from the file's metadata storage\.

```csharp
public TMetadata? GetMetadata<TMetadata>()
    where TMetadata : DiGi.Core.IO.Interfaces.IMetadata;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.File.GetMetadata_TMetadata_().TMetadata'></a>

`TMetadata`

The type of metadata to retrieve\.

#### Returns
[TMetadata](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File.GetMetadata_TMetadata_().TMetadata 'DiGi\.Core\.IO\.File\.Classes\.File\.GetMetadata\<TMetadata\>\(\)\.TMetadata')  
The metadata of type [TMetadata](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File.GetMetadata_TMetadata_().TMetadata 'DiGi\.Core\.IO\.File\.Classes\.File\.GetMetadata\<TMetadata\>\(\)\.TMetadata') if found; otherwise, null\.

<a name='DiGi.Core.IO.File.Classes.File.Open()'></a>

## File\.Open\(\) Method

Opens the file using its current path\.

```csharp
public virtual bool Open();
```

Implements [Open\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.open 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Open')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was opened successfully; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.File.Open(string)'></a>

## File\.Open\(string\) Method

Opens the file from the specified path\.

```csharp
public bool Open(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.File.Open(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the file to open\.

Implements [Open\(string\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.open#digi-core-io-file-interfaces-ifile-open(system-string) 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Open\(System\.String\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was opened successfully; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.File.Save()'></a>

## File\.Save\(\) Method

Saves the file's metadata and updates its modification date\.

```csharp
public virtual bool Save();
```

Implements [Save\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.save 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Save')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the save operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.File.SaveAs(string)'></a>

## File\.SaveAs\(string\) Method

Saves the file to the specified path\.

```csharp
public bool SaveAs(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.File.SaveAs(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path where the file should be saved\.

Implements [SaveAs\(string\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.saveas#digi-core-io-file-interfaces-ifile-saveas(system-string) 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.SaveAs\(System\.String\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file was saved successfully; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.File.SetMetadata(DiGi.Core.IO.Interfaces.IMetadata)'></a>

## File\.SetMetadata\(IMetadata\) Method

Sets a custom metadata object for the file\.

```csharp
public void SetMetadata(DiGi.Core.IO.Interfaces.IMetadata? metadata);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.File.SetMetadata(DiGi.Core.IO.Interfaces.IMetadata).metadata'></a>

`metadata` [DiGi\.Core\.IO\.Interfaces\.IMetadata](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.imetadata 'DiGi\.Core\.IO\.Interfaces\.IMetadata')

The metadata object to set\.

<a name='DiGi.Core.IO.File.Classes.FileMetadata'></a>

## FileMetadata Class

Stores metadata for a file, including creation and modification dates, path, and type\.

```csharp
public class FileMetadata : DiGi.Core.Classes.GuidObject, DiGi.Core.IO.Interfaces.IMetadata, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.IO.Wrapper.Interfaces.IWrapperObject, DiGi.Core.IO.Interfaces.IIOObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → FileMetadata

Implements [DiGi\.Core\.IO\.Interfaces\.IMetadata](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.imetadata 'DiGi\.Core\.IO\.Interfaces\.IMetadata'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.IO\.Wrapper\.Interfaces\.IWrapperObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.wrapper.interfaces.iwrapperobject 'DiGi\.Core\.IO\.Wrapper\.Interfaces\.IWrapperObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject')
### Constructors

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(DiGi.Core.IO.File.Classes.FileMetadata)'></a>

## FileMetadata\(FileMetadata\) Constructor

Initializes a new instance of the [FileMetadata](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.FileMetadata 'DiGi\.Core\.IO\.File\.Classes\.FileMetadata') class by cloning another metadata object\.

```csharp
public FileMetadata(DiGi.Core.IO.File.Classes.FileMetadata? fileMetadata);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(DiGi.Core.IO.File.Classes.FileMetadata).fileMetadata'></a>

`fileMetadata` [FileMetadata](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.FileMetadata 'DiGi\.Core\.IO\.File\.Classes\.FileMetadata')

The source metadata object to clone\.

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(System.Text.Json.Nodes.JsonObject)'></a>

## FileMetadata\(JsonObject\) Constructor

Initializes a new instance of the [FileMetadata](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.FileMetadata 'DiGi\.Core\.IO\.File\.Classes\.FileMetadata') class from a JSON object\.

```csharp
public FileMetadata(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the metadata\.

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(System.Type)'></a>

## FileMetadata\(Type\) Constructor

Initializes a new instance of the [FileMetadata](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.FileMetadata 'DiGi\.Core\.IO\.File\.Classes\.FileMetadata') class with type\.

```csharp
public FileMetadata(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to be associated with this metadata\.

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(System.Type,string)'></a>

## FileMetadata\(Type, string\) Constructor

Initializes a new instance of the [FileMetadata](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.FileMetadata 'DiGi\.Core\.IO\.File\.Classes\.FileMetadata') class with type and path\.

```csharp
public FileMetadata(System.Type? type, string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(System.Type,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to be associated with this metadata\.

<a name='DiGi.Core.IO.File.Classes.FileMetadata.FileMetadata(System.Type,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to be associated with this metadata\.
### Properties

<a name='DiGi.Core.IO.File.Classes.FileMetadata.Created'></a>

## FileMetadata\.Created Property

Gets the date and time when the file was created\.

```csharp
public System.DateTime Created { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Core.IO.File.Classes.FileMetadata.Modified'></a>

## FileMetadata\.Modified Property

Gets or sets the date and time when the file was last modified\.

```csharp
public System.DateTime Modified { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Core.IO.File.Classes.FileMetadata.Path'></a>

## FileMetadata\.Path Property

Gets or sets the path of the file\.

```csharp
public string? Path { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.IO.File.Classes.FileMetadata.Type'></a>

## FileMetadata\.Type Property

Gets the full type name of the file\.

```csharp
public string? Type { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.IO.File.Classes.StorageFile'></a>

## StorageFile Class

Represents a file used for storing and managing serializable objects\.

```csharp
public class StorageFile : DiGi.Core.IO.File.Classes.StorageFile<DiGi.Core.Interfaces.ISerializableObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>') → StorageFile
### Constructors

<a name='DiGi.Core.IO.File.Classes.StorageFile.StorageFile(DiGi.Core.IO.File.Classes.StorageFile)'></a>

## StorageFile\(StorageFile\) Constructor

Initializes a new instance of the [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile') class from another storage file instance\.

```csharp
public StorageFile(DiGi.Core.IO.File.Classes.StorageFile? storageFile);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile.StorageFile(DiGi.Core.IO.File.Classes.StorageFile).storageFile'></a>

`storageFile` [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile')

The source storage file instance\.

<a name='DiGi.Core.IO.File.Classes.StorageFile.StorageFile(string)'></a>

## StorageFile\(string\) Constructor

Initializes a new instance of the [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile') class using the specified file path\.

```csharp
public StorageFile(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile.StorageFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the storage file\.

<a name='DiGi.Core.IO.File.Classes.StorageFile.StorageFile(System.Text.Json.Nodes.JsonObject)'></a>

## StorageFile\(JsonObject\) Constructor

Initializes a new instance of the [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile') class from the provided JSON object\.

```csharp
public StorageFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile.StorageFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the storage file from\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_'></a>

## StorageFile\<TSerializableObject\> Class

Represents a file used for storing and managing serializable objects\.

```csharp
public class StorageFile<TSerializableObject> : DiGi.Core.IO.File.Classes.File, DiGi.Core.IO.File.Interfaces.IValuesFile<TSerializableObject>, DiGi.Core.IO.File.Interfaces.IValuesFile, DiGi.Core.IO.File.Interfaces.IFile, System.IDisposable
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of serializable object that this storage file manages\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') → StorageFile\<TSerializableObject\>

Derived  
↳ [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile')

Implements [DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile-1 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile\`1')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile-1 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile\`1'), [DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile'), [DiGi\.Core\.IO\.File\.Interfaces\.IFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile 'DiGi\.Core\.IO\.File\.Interfaces\.IFile'), [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.StorageFile(DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_)'></a>

## StorageFile\(StorageFile\<TSerializableObject\>\) Constructor

Initializes a new instance of the [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile') class from an existing typed storage file\.

```csharp
public StorageFile(DiGi.Core.IO.File.Classes.StorageFile<TSerializableObject>? storageFile);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.StorageFile(DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_).storageFile'></a>

`storageFile` [DiGi\.Core\.IO\.File\.Classes\.StorageFile&lt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>')

The existing typed storage file to initialize from\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.StorageFile(string)'></a>

## StorageFile\(string\) Constructor

Initializes a new instance of the [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile') class using the specified file path\.

```csharp
public StorageFile(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.StorageFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The system path to the storage file\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.StorageFile(System.Text.Json.Nodes.JsonObject)'></a>

## StorageFile\(JsonObject\) Constructor

Initializes a new instance of the [StorageFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile 'DiGi\.Core\.IO\.File\.Classes\.StorageFile') class from the provided JSON object\.

```csharp
public StorageFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.StorageFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the storage file\.
### Properties

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Count'></a>

## StorageFile\<TSerializableObject\>\.Count Property

Gets the total number of elements contained in the storage file\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Values'></a>

## StorageFile\<TSerializableObject\>\.Values Property

Gets all stored values as a collection of serializable objects\.

```csharp
public System.Collections.Generic.IEnumerable<TSerializableObject?>? Values { get; set; }
```

Implements [Values](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile-1.values 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile\`1\.Values')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.AddValue(TSerializableObject)'></a>

## StorageFile\<TSerializableObject\>\.AddValue\(TSerializableObject\) Method

Adds a serializable object to the storage and returns its unique reference\.

```csharp
public DiGi.Core.Classes.UniqueReference? AddValue(TSerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.AddValue(TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')

The serializable object to be added to the storage\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference of the added object, or null if the operation failed\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Contains(DiGi.Core.Classes.UniqueReference)'></a>

## StorageFile\<TSerializableObject\>\.Contains\(UniqueReference\) Method

Determines whether the storage contains an object associated with the specified unique reference\.

```csharp
public bool Contains(DiGi.Core.Classes.UniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Contains(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference to check for\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the storage contains an object associated with the specified unique reference; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetUndecodableEntryNames()'></a>

## StorageFile\<TSerializableObject\>\.GetUndecodableEntryNames\(\) Method

Gets the names of the value entries of the file whose name does not decode to a unique reference \- entries written in a former reference format\.

Such an entry is skipped by [GetUniqueReferences\(\)](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetUniqueReferences() 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.GetUniqueReferences\(\)'), [Count](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Count 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.Count') and every value read, so a reader sees the file as partly or wholly empty; [Save\(\)](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Save() 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.Save\(\)') refuses a file holding one (DiGi-Organization/DiGi.GIS.PostgreSQL#149).

```csharp
public System.Collections.Generic.List<string>? GetUndecodableEntryNames();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The full names of the undecodable value entries, empty when every entry decodes; null when the file does not exist\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetUniqueReference(TSerializableObject)'></a>

## StorageFile\<TSerializableObject\>\.GetUniqueReference\(TSerializableObject\) Method

Retrieves the unique reference for the specified serializable object\.

```csharp
public virtual DiGi.Core.Classes.UniqueReference? GetUniqueReference(TSerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetUniqueReference(TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')

The serializable object to retrieve the reference for\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference associated with the specified serializable object, or null\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetUniqueReferences()'></a>

## StorageFile\<TSerializableObject\>\.GetUniqueReferences\(\) Method

Gets a set of all unique references stored in the file\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Core.Classes.UniqueReference>? GetUniqueReferences();
```

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A hash set containing all unique references stored in the file, or null\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue(DiGi.Core.Classes.UniqueReference)'></a>

## StorageFile\<TSerializableObject\>\.GetValue\(UniqueReference\) Method

Retrieves the typed value associated with the specified unique reference\.

```csharp
public TSerializableObject? GetValue(DiGi.Core.Classes.UniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference to retrieve the value for\.

#### Returns
[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')  
The typed value associated with the specified unique reference, or null if not found\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue(System.Nullable_int_)'></a>

## StorageFile\<TSerializableObject\>\.GetValue\(Nullable\<int\>\) Method

Retrieves the typed object at the specified index\.

```csharp
public TSerializableObject? GetValue(System.Nullable<int> index);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue(System.Nullable_int_).index'></a>

`index` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The index of the object to retrieve\.

#### Returns
[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')  
The typed object at the specified index, or null if not found\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference)'></a>

## StorageFile\<TSerializableObject\>\.GetValue\<USerializableObject\>\(UniqueReference\) Method

Retrieves the base serializable object associated with the specified unique reference\.

```csharp
public USerializableObject? GetValue<USerializableObject>(DiGi.Core.Classes.UniqueReference? uniqueReference)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference).USerializableObject'></a>

`USerializableObject`

The type of the serializable object\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference to retrieve the value for\.

#### Returns
[USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.GetValue\<USerializableObject\>\(DiGi\.Core\.Classes\.UniqueReference\)\.USerializableObject')  
The base serializable object associated with the specified unique reference, or null if not found\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(int)'></a>

## StorageFile\<TSerializableObject\>\.GetValue\<USerializableObject\>\(int\) Method

Retrieves the object at the specified index\.

```csharp
public USerializableObject? GetValue<USerializableObject>(int index)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(int).USerializableObject'></a>

`USerializableObject`

The type of serializable object to retrieve\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the object to retrieve\.

#### Returns
[USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValue_USerializableObject_(int).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.GetValue\<USerializableObject\>\(int\)\.USerializableObject')  
The object at the specified index, or null if not found\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## StorageFile\<TSerializableObject\>\.GetValues\(IEnumerable\<UniqueReference\>\) Method

Retrieves a typed collection of objects associated with the provided set of unique references\.

```csharp
public System.Collections.Generic.IEnumerable<TSerializableObject?>? GetValues(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to retrieve values for\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of typed objects associated with the provided unique references, or null if not available\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues(System.Collections.Generic.IEnumerable_int_)'></a>

## StorageFile\<TSerializableObject\>\.GetValues\(IEnumerable\<int\>\) Method

Retrieves a typed collection of objects at the specified indices\.

```csharp
public System.Collections.Generic.IEnumerable<TSerializableObject?>? GetValues(System.Collections.Generic.IEnumerable<int>? indexes);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues(System.Collections.Generic.IEnumerable_int_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of indices for which to retrieve values\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of typed objects corresponding to the provided indices, or null if not available\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_()'></a>

## StorageFile\<TSerializableObject\>\.GetValues\<USerializableObject\>\(\) Method

Retrieves all stored objects as a collection\.

```csharp
public System.Collections.Generic.IEnumerable<USerializableObject?>? GetValues<USerializableObject>()
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_().USerializableObject'></a>

`USerializableObject`

The type of serializable objects being retrieved\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_().USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.GetValues\<USerializableObject\>\(\)\.USerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of all stored objects, or null if the collection is empty\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## StorageFile\<TSerializableObject\>\.GetValues\<USerializableObject\>\(IEnumerable\<UniqueReference\>\) Method

Retrieves a collection of objects associated with the provided set of unique references\.

```csharp
public System.Collections.Generic.IEnumerable<USerializableObject?>? GetValues<USerializableObject>(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).USerializableObject'></a>

`USerializableObject`

The type of serializable object to retrieve\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to retrieve values for\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.GetValues\<USerializableObject\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Classes\.UniqueReference\>\)\.USerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of objects associated with the provided unique references, or null if not available\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_int_)'></a>

## StorageFile\<TSerializableObject\>\.GetValues\<USerializableObject\>\(IEnumerable\<int\>\) Method

Retrieves a collection of objects at the specified indices\.

```csharp
public System.Collections.Generic.IEnumerable<USerializableObject?>? GetValues<USerializableObject>(System.Collections.Generic.IEnumerable<int>? indexes)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_int_).USerializableObject'></a>

`USerializableObject`

The type of serializable objects being retrieved\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_int_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of indices to retrieve objects from\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetValues_USerializableObject_(System.Collections.Generic.IEnumerable_int_).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.GetValues\<USerializableObject\>\(System\.Collections\.Generic\.IEnumerable\<int\>\)\.USerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of objects found at the specified indices, or null if no objects were found\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Open()'></a>

## StorageFile\<TSerializableObject\>\.Open\(\) Method

Opens the storage file for reading and writing\.

```csharp
public override bool Open();
```

Implements [Open\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.open 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Open')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the storage file was opened successfully; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Remove(DiGi.Core.Classes.UniqueReference)'></a>

## StorageFile\<TSerializableObject\>\.Remove\(UniqueReference\) Method

Removes the object associated with the specified unique reference\.

```csharp
public bool Remove(DiGi.Core.Classes.UniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Remove(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference of the object to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully removed; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## StorageFile\<TSerializableObject\>\.Remove\(IEnumerable\<UniqueReference\>\) Method

Removes all objects associated with the provided set of unique references\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Core.Classes.UniqueReference>? Remove(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to be removed\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A HashSet containing the unique references that were successfully removed, or null if no objects were removed\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveAll_USerializableObject_(System.Func_USerializableObject,bool_)'></a>

## StorageFile\<TSerializableObject\>\.RemoveAll\<USerializableObject\>\(Func\<USerializableObject,bool\>\) Method

Removes all objects that satisfy the specified condition and returns their references\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Core.Classes.UniqueReference>? RemoveAll<USerializableObject>(System.Func<USerializableObject?,bool>? func)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveAll_USerializableObject_(System.Func_USerializableObject,bool_).USerializableObject'></a>

`USerializableObject`

The type of the serializable objects being evaluated\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveAll_USerializableObject_(System.Func_USerializableObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveAll_USerializableObject_(System.Func_USerializableObject,bool_).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.RemoveAll\<USerializableObject\>\(System\.Func\<USerializableObject,bool\>\)\.USerializableObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to determine which objects to remove\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A set containing the unique references of all removed objects, or null if no objects were removed\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveFirst_USerializableObject_(System.Func_USerializableObject,bool_)'></a>

## StorageFile\<TSerializableObject\>\.RemoveFirst\<USerializableObject\>\(Func\<USerializableObject,bool\>\) Method

Removes the first object that satisfies the specified condition and returns its reference\.

```csharp
public DiGi.Core.Classes.UniqueReference? RemoveFirst<USerializableObject>(System.Func<USerializableObject?,bool>? func)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveFirst_USerializableObject_(System.Func_USerializableObject,bool_).USerializableObject'></a>

`USerializableObject`

The type of the serializable objects being evaluated\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveFirst_USerializableObject_(System.Func_USerializableObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.RemoveFirst_USerializableObject_(System.Func_USerializableObject,bool_).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.RemoveFirst\<USerializableObject\>\(System\.Func\<USerializableObject,bool\>\)\.USerializableObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A predicate function to determine which object to remove\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The unique reference of the removed object, or null if no object satisfied the condition\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.Save()'></a>

## StorageFile\<TSerializableObject\>\.Save\(\) Method

Saves the current state of the storage file to disk\.

Refuses - writes nothing and returns false - when the file holds a value entry whose name does not decode to a unique reference ([GetUndecodableEntryNames\(\)](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.GetUndecodableEntryNames() 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.GetUndecodableEntryNames\(\)')): such an entry, written in a former reference format, is invisible to every reader, and saving beside it would leave two copies of the same values (DiGi-Organization/DiGi.GIS.PostgreSQL#149).

```csharp
public override bool Save();
```

Implements [Save\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.save 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Save')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the save operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue(DiGi.Core.Classes.UniqueReference,TSerializableObject)'></a>

## StorageFile\<TSerializableObject\>\.TryGetValue\(UniqueReference, TSerializableObject\) Method

Attempts to retrieve a typed value for the specified unique reference\.

```csharp
public bool TryGetValue(DiGi.Core.Classes.UniqueReference? uniqueReference, out TSerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue(DiGi.Core.Classes.UniqueReference,TSerializableObject).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference of the object to retrieve\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue(DiGi.Core.Classes.UniqueReference,TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')

When this method returns, contains the retrieved object if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue(int,TSerializableObject)'></a>

## StorageFile\<TSerializableObject\>\.TryGetValue\(int, TSerializableObject\) Method

Attempts to retrieve a typed value at the specified index\.

```csharp
public bool TryGetValue(int index, out TSerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue(int,TSerializableObject).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to get\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue(int,TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TSerializableObject')

When this method returns, contains the object corresponding to the specified index, if found; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element exists at the specified index; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference,USerializableObject)'></a>

## StorageFile\<TSerializableObject\>\.TryGetValue\<USerializableObject\>\(UniqueReference, USerializableObject\) Method

Attempts to retrieve a base serializable object for the specified unique reference\.

```csharp
public bool TryGetValue<USerializableObject>(DiGi.Core.Classes.UniqueReference? uniqueReference, out USerializableObject? serializableObject)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference,USerializableObject).USerializableObject'></a>

`USerializableObject`

The type of the serializable object\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference,USerializableObject).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference of the object to retrieve\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference,USerializableObject).serializableObject'></a>

`serializableObject` [USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(DiGi.Core.Classes.UniqueReference,USerializableObject).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TryGetValue\<USerializableObject\>\(DiGi\.Core\.Classes\.UniqueReference, USerializableObject\)\.USerializableObject')

When this method returns, contains the retrieved object if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(System.Nullable_int_,USerializableObject)'></a>

## StorageFile\<TSerializableObject\>\.TryGetValue\<USerializableObject\>\(Nullable\<int\>, USerializableObject\) Method

Attempts to retrieve a base serializable object at the specified index\.

```csharp
public bool TryGetValue<USerializableObject>(System.Nullable<int> index, out USerializableObject? serializableObject)
    where USerializableObject : TSerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(System.Nullable_int_,USerializableObject).USerializableObject'></a>

`USerializableObject`

The type of the serializable object\.
#### Parameters

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(System.Nullable_int_,USerializableObject).index'></a>

`index` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The zero\-based index of the element to get\.

<a name='DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(System.Nullable_int_,USerializableObject).serializableObject'></a>

`serializableObject` [USerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.StorageFile_TSerializableObject_.TryGetValue_USerializableObject_(System.Nullable_int_,USerializableObject).USerializableObject 'DiGi\.Core\.IO\.File\.Classes\.StorageFile\<TSerializableObject\>\.TryGetValue\<USerializableObject\>\(System\.Nullable\<int\>, USerializableObject\)\.USerializableObject')

When this method returns, contains the object corresponding to the specified index, if found; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element exists at the specified index; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.ValueFile'></a>

## ValueFile Class

Represents a file that stores a single value\.

```csharp
public class ValueFile : DiGi.Core.IO.File.Classes.ValueFile<DiGi.Core.Interfaces.ISerializableObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.ValueFile&lt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>') → ValueFile
### Constructors

<a name='DiGi.Core.IO.File.Classes.ValueFile.ValueFile(DiGi.Core.IO.File.Classes.ValueFile)'></a>

## ValueFile\(ValueFile\) Constructor

Initializes a new instance of the [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile') class from an existing non\-generic value file\.

```csharp
public ValueFile(DiGi.Core.IO.File.Classes.ValueFile? valueFile);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile.ValueFile(DiGi.Core.IO.File.Classes.ValueFile).valueFile'></a>

`valueFile` [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile')

The existing non\-generic value file to initialize from\.

<a name='DiGi.Core.IO.File.Classes.ValueFile.ValueFile(string)'></a>

## ValueFile\(string\) Constructor

Initializes a new instance of the [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile') class using the specified file path\.

```csharp
public ValueFile(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile.ValueFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the value file\.

<a name='DiGi.Core.IO.File.Classes.ValueFile.ValueFile(System.Text.Json.Nodes.JsonObject)'></a>

## ValueFile\(JsonObject\) Constructor

Initializes a new instance of the [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile') class from the provided JSON object\.

```csharp
public ValueFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile.ValueFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the value file from\.

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_'></a>

## ValueFile\<TSerializableObject\> Class

Represents a file that stores a single value\.

```csharp
public class ValueFile<TSerializableObject> : DiGi.Core.IO.File.Classes.File, DiGi.Core.IO.File.Interfaces.IValueFile<TSerializableObject>, DiGi.Core.IO.File.Interfaces.IValueFile, DiGi.Core.IO.File.Interfaces.IFile, System.IDisposable
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object stored in the file\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') → ValueFile\<TSerializableObject\>

Derived  
↳ [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile')

Implements [DiGi\.Core\.IO\.File\.Interfaces\.IValueFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluefile-1 'DiGi\.Core\.IO\.File\.Interfaces\.IValueFile\`1')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluefile-1 'DiGi\.Core\.IO\.File\.Interfaces\.IValueFile\`1'), [DiGi\.Core\.IO\.File\.Interfaces\.IValueFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluefile 'DiGi\.Core\.IO\.File\.Interfaces\.IValueFile'), [DiGi\.Core\.IO\.File\.Interfaces\.IFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile 'DiGi\.Core\.IO\.File\.Interfaces\.IFile'), [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.ValueFile(DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_)'></a>

## ValueFile\(ValueFile\<TSerializableObject\>\) Constructor

Initializes a new instance of the [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile') class from an existing generic value file\.

```csharp
public ValueFile(DiGi.Core.IO.File.Classes.ValueFile<TSerializableObject>? valueFile);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.ValueFile(DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_).valueFile'></a>

`valueFile` [DiGi\.Core\.IO\.File\.Classes\.ValueFile&lt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>')

The existing generic value file to initialize from\.

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.ValueFile(string)'></a>

## ValueFile\(string\) Constructor

Initializes a new instance of the [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile') class using the specified file path\.

```csharp
public ValueFile(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.ValueFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the value file\.

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.ValueFile(System.Text.Json.Nodes.JsonObject)'></a>

## ValueFile\(JsonObject\) Constructor

Initializes a new instance of the [ValueFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile 'DiGi\.Core\.IO\.File\.Classes\.ValueFile') class from the provided JSON object\.

```csharp
public ValueFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.ValueFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.Value'></a>

## ValueFile\<TSerializableObject\>\.Value Property

Gets or sets the value stored within the file\.

```csharp
public TSerializableObject? Value { get; set; }
```

Implements [Value](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluefile-1.value 'DiGi\.Core\.IO\.File\.Interfaces\.IValueFile\`1\.Value')

#### Property Value
[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>\.TSerializableObject')
### Methods

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.Open()'></a>

## ValueFile\<TSerializableObject\>\.Open\(\) Method

Opens the file and loads its content into memory\.

```csharp
public override bool Open();
```

Implements [Open\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.open 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Open')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the open operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.Save()'></a>

## ValueFile\<TSerializableObject\>\.Save\(\) Method

Saves the current state of the object to the file\.

```csharp
public override bool Save();
```

Implements [Save\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.save 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Save')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the save operation was successful; otherwise, false\.
### Operators

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.op_ExplicitTSerializableObject(DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_)'></a>

## ValueFile\<TSerializableObject\>\.explicit operator TSerializableObject\(ValueFile\<TSerializableObject\>\) Operator

Explicitly converts a [ValueFile&lt;TSerializableObject&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>') to its contained value of type [TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>\.TSerializableObject')\.

```csharp
public static TSerializableObject? explicit operator TSerializableObject?(DiGi.Core.IO.File.Classes.ValueFile<TSerializableObject>? valueFile);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.op_ExplicitTSerializableObject(DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_).valueFile'></a>

`valueFile` [DiGi\.Core\.IO\.File\.Classes\.ValueFile&lt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>')

The value file to convert\.

#### Returns
[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValueFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\<TSerializableObject\>\.TSerializableObject')  
The contained value, or the default value if the file is null\.

<a name='DiGi.Core.IO.File.Classes.ValuesFile'></a>

## ValuesFile Class

Represents a file that stores a collection of values\.

```csharp
public class ValuesFile : DiGi.Core.IO.File.Classes.ValuesFile<DiGi.Core.Interfaces.ISerializableObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.ValuesFile&lt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>') → ValuesFile
### Constructors

<a name='DiGi.Core.IO.File.Classes.ValuesFile.ValuesFile(DiGi.Core.IO.File.Classes.ValuesFile)'></a>

## ValuesFile\(ValuesFile\) Constructor

Initializes a new instance of the [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile') class from an existing non\-generic values file\.

```csharp
public ValuesFile(DiGi.Core.IO.File.Classes.ValuesFile? valuesFile);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValuesFile.ValuesFile(DiGi.Core.IO.File.Classes.ValuesFile).valuesFile'></a>

`valuesFile` [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile')

The existing non\-generic values file to initialize from\.

<a name='DiGi.Core.IO.File.Classes.ValuesFile.ValuesFile(string)'></a>

## ValuesFile\(string\) Constructor

Initializes a new instance of the [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile') class using the specified file path\.

```csharp
public ValuesFile(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValuesFile.ValuesFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the values file\.

<a name='DiGi.Core.IO.File.Classes.ValuesFile.ValuesFile(System.Text.Json.Nodes.JsonObject)'></a>

## ValuesFile\(JsonObject\) Constructor

Initializes a new instance of the [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile') class from the provided JSON object\.

```csharp
public ValuesFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValuesFile.ValuesFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_'></a>

## ValuesFile\<TSerializableObject\> Class

Represents a file that stores a collection of values\.

```csharp
public class ValuesFile<TSerializableObject> : DiGi.Core.IO.File.Classes.File, DiGi.Core.IO.File.Interfaces.IValuesFile<TSerializableObject>, DiGi.Core.IO.File.Interfaces.IValuesFile, DiGi.Core.IO.File.Interfaces.IFile, System.IDisposable
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object stored in the file\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [File](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.File 'DiGi\.Core\.IO\.File\.Classes\.File') → ValuesFile\<TSerializableObject\>

Derived  
↳ [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile')

Implements [DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile-1 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile\`1')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile-1 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile\`1'), [DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile'), [DiGi\.Core\.IO\.File\.Interfaces\.IFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile 'DiGi\.Core\.IO\.File\.Interfaces\.IFile'), [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.ValuesFile(DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_)'></a>

## ValuesFile\(ValuesFile\<TSerializableObject\>\) Constructor

Initializes a new instance of the [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile') class from an existing generic values file\.

```csharp
public ValuesFile(DiGi.Core.IO.File.Classes.ValuesFile<TSerializableObject>? valuesFile);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.ValuesFile(DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_).valuesFile'></a>

`valuesFile` [DiGi\.Core\.IO\.File\.Classes\.ValuesFile&lt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_ 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>')

The existing generic values file to initialize from\.

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.ValuesFile(string)'></a>

## ValuesFile\(string\) Constructor

Initializes a new instance of the [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile') class using the specified file path\.

```csharp
public ValuesFile(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.ValuesFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the values file\.

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.ValuesFile(System.Text.Json.Nodes.JsonObject)'></a>

## ValuesFile\(JsonObject\) Constructor

Initializes a new instance of the [ValuesFile](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile') class from the provided JSON object\.

```csharp
public ValuesFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.ValuesFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.
### Properties

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.Values'></a>

## ValuesFile\<TSerializableObject\>\.Values Property

Gets or sets the collection of values stored within the file\.

```csharp
public System.Collections.Generic.IEnumerable<TSerializableObject?>? Values { get; set; }
```

Implements [Values](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ivaluesfile-1.values 'DiGi\.Core\.IO\.File\.Interfaces\.IValuesFile\`1\.Values')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.IO.File.Classes.md#DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.File\.Classes\.ValuesFile\<TSerializableObject\>\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.Open()'></a>

## ValuesFile\<TSerializableObject\>\.Open\(\) Method

Opens the file and loads its content into memory\.

```csharp
public override bool Open();
```

Implements [Open\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.open 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Open')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the open operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.File.Classes.ValuesFile_TSerializableObject_.Save()'></a>

## ValuesFile\<TSerializableObject\>\.Save\(\) Method

Saves the current state of the object to the file\.

```csharp
public override bool Save();
```

Implements [Save\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.interfaces.ifile.save 'DiGi\.Core\.IO\.File\.Interfaces\.IFile\.Save')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the save operation was successful; otherwise, false\.